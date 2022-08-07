using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoalCheckerBowling : MonoBehaviour
{
    public List<GameObject> pins = new List<GameObject>();
    public List<Vector3> pinsPosition = new List<Vector3>();
    private int points;
    public TextMeshProUGUI pointsText;
    private Vector3 ballPos;
    public GameObject checkmark;
    public GameObject backWall;
    public Material nicMaterial;
    
    void Start()
    {
        for(int i = 0; i < pins.Count; i++)
        {
            pinsPosition.Add(pins[i].transform.position);
        }
        ballPos = GameObject.FindGameObjectWithTag("bowlingBall").transform.position;
        
    }

    private void Update()
    {
        if(points == 10)
        {
            checkmark.SetActive(true);
            backWall.GetComponent<MeshRenderer>().material = nicMaterial;
            
        }
        else
        {
            checkmark.SetActive(false);
        }
    }



    public IEnumerator CountPoints()
    {
        points = 0;
        yield return new WaitForSeconds(10);
        foreach (GameObject pin in pins)
        {
            if (pin.transform.rotation != Quaternion.identity)
            {
                points++;
            }
        }
        Debug.Log("erreichte Punkte: " + points);
        pointsText.text = points.ToString();
        
        ResetPins();
        ResetBall();

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "bowlingBall")
        {
            StartCoroutine(CountPoints());
        }
    }

    private void ResetPins()
    {
        for (int i = 0; i < pins.Count; i++)
        {
            pins[i].transform.rotation = Quaternion.identity;
            pins[i].transform.position = pinsPosition[i];
            pins[i].GetComponent<Rigidbody>().velocity = Vector3.zero;
            pins[i].GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        }
    }

    private void ResetBall()
    {
        GameObject.FindGameObjectWithTag("bowlingBall").transform.position = ballPos;
        GameObject.FindGameObjectWithTag("bowlingBall").GetComponent<Rigidbody>().velocity = Vector3.zero;
        GameObject.FindGameObjectWithTag("bowlingBall").GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
}

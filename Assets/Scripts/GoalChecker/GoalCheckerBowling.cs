using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoalCheckerBowling : MonoBehaviour
{
    public List<GameObject> pins = new List<GameObject>();
    private int points;
    public TextMeshProUGUI text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator CountPoints()
    {
        yield return new WaitForSeconds(10);
        foreach (GameObject pin in pins)
        {
            if (pin.transform.rotation != Quaternion.identity)
            {
                points++;
            }
        }
        Debug.Log("erreichte Punkte: " + points);
        text.text += points;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "bowlingBall")
        {
            StartCoroutine(CountPoints());
        }
    }
}

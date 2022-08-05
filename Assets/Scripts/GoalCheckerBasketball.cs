using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCheckerBasketball : MonoBehaviour
{
    public GameObject checkbox;
    public AudioClip pointMadeSound;
    public AudioSource taskCompleteSound;
    public ScoreCounter sc;
    private int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        taskCompleteSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Basketball")
        {
            checkbox.SetActive(true);
            AudioSource.PlayClipAtPoint(pointMadeSound, transform.position, 1);
            if (counter == 0)
            {
            taskCompleteSound.PlayDelayed(0.5f);
            }

            counter++;
            sc.Increment();
        }
        
    }
}

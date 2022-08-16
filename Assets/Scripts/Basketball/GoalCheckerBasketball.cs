using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCheckerBasketball : MonoBehaviour
{
    public GameObject checkbox;
    public AudioClip pointMadeSound;
    public AudioSource taskCompleteSound;
    public ScoreCounter sc;
    private bool taskCompleted = false;
    
    private void Start()
    {
        taskCompleteSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Basketball")
        {
            AudioSource.PlayClipAtPoint(pointMadeSound, transform.position, 1);
            if (!taskCompleted)
            {
                checkbox.SetActive(true);
                taskCompleteSound.PlayDelayed(0.5f);
                taskCompleted = true;
            }
            sc.Increment();
        } 
    }
}

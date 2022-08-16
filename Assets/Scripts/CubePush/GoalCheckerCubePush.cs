using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCheckerCubePush : MonoBehaviour
{

    public GameObject checkmark;
    public bool taskComplete = false;

    private void Update()
    {
        if (taskComplete)
        {
            checkmark.SetActive(true);
        }
        else
        {
            checkmark.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "cube")
        {
            
            taskComplete = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "cube")
        {
            taskComplete = false;
        }
    }
}

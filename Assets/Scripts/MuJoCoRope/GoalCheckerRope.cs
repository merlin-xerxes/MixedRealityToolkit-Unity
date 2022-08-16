using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCheckerRope : MonoBehaviour
{
    public GameObject checkmark;
    private bool taskComplete = false;
    

    // Update is called once per frame
    void Update()
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

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Seilende")
        {
            taskComplete = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Seilende")
        {
            taskComplete = false;
        }
    }
}

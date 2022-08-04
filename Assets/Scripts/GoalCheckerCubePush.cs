using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCheckerCubePush : MonoBehaviour
{
    

    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger erkennt was");
        if(other.gameObject.tag == "cube")
        {
            Debug.Log("abgeschlossen");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("in trigger");
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("out trigger");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

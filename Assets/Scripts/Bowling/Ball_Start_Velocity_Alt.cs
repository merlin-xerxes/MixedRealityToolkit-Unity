using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Start_Velocity_Alt : MonoBehaviour
{
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5,0,20);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectResetter : MonoBehaviour
{
    public GameObject ball;
    public Vector3 startPos;
    public Quaternion startRot;

    public void Start() 
    {
        
        startPos = ball.transform.position;
        startRot = ball.transform.rotation;
    }

    public void ResetObject()
    {
        ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
        ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        ball.transform.position = startPos;
        ball.transform.rotation = startRot;
    }
}
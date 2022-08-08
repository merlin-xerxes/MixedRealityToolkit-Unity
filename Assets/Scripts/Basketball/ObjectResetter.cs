using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectResetter : MonoBehaviour
{
    public GameObject obj;
    public Vector3 startPos;
    public Quaternion startRot;

    private void Start() 
    {
        startPos = obj.transform.position;
        startRot = obj.transform.rotation;
    }

    public void ResetObject()
    {
        obj.GetComponent<Rigidbody>().velocity = Vector3.zero;
        obj.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        obj.transform.position = startPos;
        obj.transform.rotation = startRot;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCounter : MonoBehaviour
{
    public int pointCounter = 0;

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "marble") {
            pointCounter = 1;
        }
    }

    void OnTriggerExit(Collider other) {
        if(other.gameObject.tag == "marble") {
            pointCounter = 0;
        }
    }
}

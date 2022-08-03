using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCounter : MonoBehaviour
{
    public int pointCounter = 0;

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "marble") {
            pointCounter++;
        }
    }

    void OnTriggerExit(Collider other) {
        if(other.gameObject.name == "marble") {
            pointCounter--;
        }
    }
}

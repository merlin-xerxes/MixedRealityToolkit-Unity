using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialColor : MonoBehaviour
{

     public Color greencolor;
 
 
     void OnTriggerEnter(Collider other) {
 
         if (other.gameObject.CompareTag ("Marble")) 
         {           
             transform.GetComponent<Renderer>().material.color= greencolor;
         }
     }
}

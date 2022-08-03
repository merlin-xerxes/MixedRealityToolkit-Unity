using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialColor : MonoBehaviour
{
    
     public Color greencolor;
     private ColliderCounter cc;
     private int incrementCounter = 0;

     void OnTriggerEnter(Collider other) {
 
         if (other.gameObject.CompareTag ("Marble")) 
         {           
             transform.GetComponent<Renderer>().material.color= greencolor;
             if (incrementCounter < 1)
             {
                cc.increment();
                incrementCounter++;
             }
         }
     }
}

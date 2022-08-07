using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialColor : MonoBehaviour
{
    
     public Color greencolor;
     public ColliderCounter cc;
     public AudioClip collsionSound;
     private int incrementCounter = 0;

     void OnTriggerEnter(Collider other) {
 
         if (other.gameObject.CompareTag ("Marble")) 
         {           
             transform.GetComponent<Renderer>().material.color= greencolor;
             AudioSource.PlayClipAtPoint(collsionSound, transform.position, 1);
             if (incrementCounter < 1)
             {
                cc.Increment();
                incrementCounter++;
             }
         }
     }
}

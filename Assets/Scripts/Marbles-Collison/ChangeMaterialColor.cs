using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialColor : MonoBehaviour
{
    public ColliderCounter cc;
    public Color collidedColor;
    public AudioClip collisionSound;
    private bool collidedWithOrange = false;

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("Orange Marble")) 
        {
            AudioSource.PlayClipAtPoint(collisionSound, transform.position, 1);
            if (!collidedWithOrange)
            {
                transform.GetComponent<Renderer>().material.color = collidedColor;
                cc.Increment();
                collidedWithOrange = true;
            }
        }
    }
}

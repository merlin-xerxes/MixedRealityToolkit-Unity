using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    

   public void ObjectSpawn()
    {
        Instantiate(objectToSpawn, transform.position, Quaternion.identity);
    }
}
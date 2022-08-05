using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPins : MonoBehaviour
{
    public List<GameObject> pins = new List<GameObject>();
    private List<Transform> originalLocations = new List<Transform>();
    void Start()
    {
        for(int i = 0; i < pins.Count; i++)
        {
            
            originalLocations.Add(pins[i].transform);
        }
    }

    public void Resetpins()
    {
        Debug.Log("Reset");
        for (int i = 0; i < pins.Count; i++)
        {
           pins[i].transform.position = originalLocations[i].position;
           pins[i].transform.rotation = originalLocations[i].rotation;
        }
    }
}

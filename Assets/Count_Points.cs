using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count_Points : MonoBehaviour
{
    List<PointCounter> counters = new List<PointCounter>();
    public int totalPoints = 0;

    void Update() 
    {
        foreach(PointCounter counter in counters) 
        {
            totalPoints += counter.pointCounter;
        }
        Debug.Log(totalPoints);
    }
}
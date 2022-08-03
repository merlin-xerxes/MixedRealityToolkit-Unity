using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count_Points : MonoBehaviour
{
    list<PointCounter> counters = new list<PointCounter>();
    private int totalPoints = 0;

    void Update() 
    {
        foreach(PointCounter counter in counters) 
        {
            totalPoints += counter.pointCounter;
        }
        Debug.log(totalPoints);
    }
}
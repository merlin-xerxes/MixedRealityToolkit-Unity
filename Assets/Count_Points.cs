using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count_Points : MonoBehaviour
{
    public List<PointCounter> counters = new List<PointCounter>();

    public int totalPoints;

    public void CountPoints()
    {
        totalPoints = 0;
        foreach (PointCounter counter in counters)
        {
            totalPoints += counter.pointCounter;
        }
        
            Debug.Log(totalPoints);
    }
}

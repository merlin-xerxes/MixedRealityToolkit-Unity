using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Count_Points : MonoBehaviour
{
    public List<PointCounter> counters = new List<PointCounter>();
    public GameObject checkMark;
    public TextMeshProUGUI pointsText;
    public int totalPoints;

    public void CountPoints()
    {
        totalPoints = 0;
        foreach (PointCounter counter in counters)
        {
            totalPoints += counter.pointCounter;
        }
    }

    void Update() {
        CountPoints();
        pointsText.text = totalPoints.ToString();
        if(totalPoints >= 3) {
            checkMark.SetActive(true);
        } else {
            checkMark.SetActive(false);
        }
    }
}

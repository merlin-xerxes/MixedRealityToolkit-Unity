using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionLogger : Logger
{
    private List<Transform> positions = new List<Transform>();

    public Transform trans;

    private int counter = 0;

    public override List<string> GetData()
    {
        return Stringify();
    }

    public override void WriteData()
    {
        Debug.Log(counter);
        positions[0] = trans;
        Debug.Log("in PositionLogger Ausführung: " + counter + " aktuelle Position: " + positions[counter].position);
        counter++;

    }

    public override List<string> Stringify()
    {
        List<string> stringPositions = new List<string>();

        for(int i = 0; i < positions.Count; i++)
        {
            stringPositions[i] = positions[i].ToString();
        }

        return stringPositions;
    }
}

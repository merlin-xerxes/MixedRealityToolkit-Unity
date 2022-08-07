using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;

public class HeadTrackingLogger : Logger
{
    private List<Vector3> position = new List<Vector3>();

    private List<Vector3> direction = new List<Vector3>();

    private GazeProvider prov;


    private void Start()
    {
        prov = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GazeProvider>();
        header = "HeadPosition; HeadDirection";
    }


    public override List<string> GetData()
    {
        return Stringify();
    }


    public override void WriteData()
    {
        Debug.Log("In HeadTrackingLogger.WriteData()");
        position.Add(prov.GazeOrigin);
        direction.Add(prov.HeadMovementDirection);
    }


    public override List<string> Stringify()
    {
        List<string> stringData = new List<string>();
        for (int i = 0; i < position.Count; i++)
        {
            stringData.Add(position[i].ToString() + "; " + direction[i].ToString());
        }
        return stringData;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Microsoft.MixedReality.Toolkit.Input;

public class EyeTrackingLogger : Logger
{
    private List<Vector3> gazeOrigins = new List<Vector3>();

    private List<Vector3> gazeDirections = new List<Vector3>();

    private List<string> gazeTargets = new List<string>();

    private GazeProvider prov;


    private void Start()
    {
        prov = GameObject.Find("Main Camera").GetComponent<GazeProvider>();
        header = "GazeTargets; GazeOrigin; GazeDirections";   
    }


    public override List<string> GetData()
    {
        return Stringify();
    }

    
    public override void WriteData()
    {
        Debug.Log("In EyeTrackingLogger.WriteData()");
        
        gazeDirections.Add(prov.GazeDirection);
        gazeOrigins.Add(prov.GazeOrigin);
        if (prov.GazeTarget == null)
        {
            gazeTargets.Add("none");
        }
        else
        {
            gazeTargets.Add(prov.GazeTarget.name);
        }
    }


    public override List<string> Stringify()
    {
        List<string> stringData = new List<string>();
        for (int i = 0; i < gazeTargets.Count; i++)
        {
            stringData.Add(gazeTargets[i].ToString() + "; " + gazeOrigins[i].ToString() + "; " + gazeDirections[i].ToString());
        }
        return stringData;
    }

}

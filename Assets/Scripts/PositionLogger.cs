using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Microsoft.MixedReality.Toolkit.Input;


public class PositionLogger : Logger
{
    private List<Vector3> GazeDirections = new List<Vector3>();
    private List<string> GazeTargets = new List<string>();



    public Transform trans;

    private int counter;

    public GazeProvider prov;

    
    private void Start()
    {
        header = "gazeTargets , gazeDirections";


        counter = 0;
    }
    public override List<string> GetData()
    {
        return Stringify();
    }



    public override void WriteData()
    {
        Debug.Log("In PositionLogger.WriteData()");
        //Debug.Log(counter);
        //Debug.Log("Blickrichtung: " + prov.GazeDirection);
        //Debug.Log("BlickObjekt: " + prov.GazeTarget.name);
        GazeDirections.Add(prov.GazeDirection);
        if (prov.GazeTarget == null) { GazeTargets.Add("null"); } else { GazeTargets.Add(prov.GazeTarget.name); }
        
        Debug.Log("GazeDirections " + counter + " " + GazeDirections[counter] );
        Debug.Log("GazeTargets " + counter + " " + GazeTargets[counter]);
        //positions[0] = trans;
        //Debug.Log("in PositionLogger Ausführung: " + counter + " aktuelle Position: " + positions[counter].position);
        counter++;

    }

    

    public override List<string> Stringify()
    {
        List<string> stringData = new List<string>();

        for(int i = 0; i < GazeTargets.Count; i++)
        {
            stringData.Add(GazeTargets[i].ToString() + ";" + GazeDirections[i].ToString());
        }

        return stringData;
    }
}

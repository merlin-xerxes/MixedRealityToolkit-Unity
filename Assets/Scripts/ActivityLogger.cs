using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;
using Microsoft.MixedReality.Toolkit;

public class ActivityLogger :Logger
{
    private List<Vector3> LHPosition = new List<Vector3>();

    private List<Vector3> RHPosition = new List<Vector3>();

    private const float PinchThreshold = 0.7f;
    


    private void Start()
    {
        Debug.Log(Handedness.Right.ToString());
        header = "RHPosition; LHPosition";
    }


    public override List<string> GetData()
    {
        return Stringify();
    }


    public override void WriteData()
    {
        Debug.Log("In HeadTrackingLogger.WriteData()");
        //muss noch angepasst werden!
        if(HandPoseUtils.IsIndexGrabbing(Handedness.Right) && HandPoseUtils.IsThumbGrabbing(Handedness.Right))
        {
            
            Debug.Log("Pinching");
        }


    }


    public override List<string> Stringify()
    {
        List<string> stringData = new List<string>();
        for (int i = 0; i < RHPosition.Count; i++)
        {
            stringData.Add(RHPosition[i].ToString() + "; " + LHPosition[i].ToString());
        }
        return stringData;
    }
}

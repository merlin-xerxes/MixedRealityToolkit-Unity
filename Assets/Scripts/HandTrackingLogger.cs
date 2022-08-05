using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;

public class HandTrackingLogger : Logger
{
    private List<Vector3> LHPosition = new List<Vector3>();

    private List<Vector3> RHPosition = new List<Vector3>();

    private MixedRealityPose pose;


    private void Start()
    {
        
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
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Right, out pose))
        {
            RHPosition.Add(pose.Position);
        }
        else
        {
            RHPosition.Add(Vector3.zero);
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Left, out pose))
        {
            LHPosition.Add(pose.Position);
        }
        else
        {
            LHPosition.Add(Vector3.zero);
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

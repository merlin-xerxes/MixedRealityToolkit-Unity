using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Microsoft.MixedReality.Toolkit.Input;

public class EyeTrackingLogger : Logger
{
    private List<Vector3> gazeOrigins;

    private List<Vector3> gazeDirections;

    private List<GameObject> gazeTargets;

    GazeProvider gazeProvider;

    public override void WriteData()
    {

    }

    public override List<string> GetData()
    {
        return null;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeTrackingLogger : Logger
{
    private List<Vector3> gazeOrigins;

    private List<Vector3> gazeDirections;

    private List<GameObject> gazeTargets;

    public override void WriteData()
    {

    }

    public override List<string> GetData()
    {
        return null;
    }

}

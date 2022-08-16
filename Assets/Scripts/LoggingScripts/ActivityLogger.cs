using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;
using Microsoft.MixedReality.Toolkit;

public class ActivityLogger :Logger
{
    private List<string> manipulatedObjects = new List<string>();

    private List<Vector3> manipulatedPosition = new List<Vector3>();

    private List<Quaternion> manipulatedRotation = new List<Quaternion>();

    private List<Vector3> manipulatedScale = new List<Vector3>();

    private GameObject interactedWith;


    private void Start()
    {
        header = "manipulatedObject; ManipulatedObjectPosition; ManipulatedObjectRotation; ManipulatedObjectScale";
        interactedWith = null;
    }

    


    public override List<string> GetData()
    {
        return Stringify();
    }


    public override void WriteData()
    {
        //Debug.Log("In ActivityTrackingLogger.WriteData()");
        
        if(interactedWith == null)
        {
            manipulatedObjects.Add("none");
            manipulatedPosition.Add(Vector3.zero);
            manipulatedRotation.Add(Quaternion.identity);
            manipulatedScale.Add(Vector3.one);
        }
        else
        {
            manipulatedObjects.Add(interactedWith.name);
            manipulatedPosition.Add(interactedWith.transform.position);
            manipulatedRotation.Add(interactedWith.transform.rotation);
            manipulatedScale.Add(interactedWith.transform.localScale);
        }
        

    }

    public void SetInteracted(GameObject obj)
    {
        interactedWith = obj;
    }

    public void ResetInteracted()
    {
        interactedWith = null;
    }


    public override List<string> Stringify()
    {
        List<string> stringData = new List<string>();
        for (int i = 0; i < manipulatedObjects.Count; i++)
        {
            stringData.Add(manipulatedObjects[i].ToString() + ";" + manipulatedPosition[i].ToString() + ";" + manipulatedRotation[i].ToString() + ";" + manipulatedScale[i].ToString());
        }
        return stringData;
    }
}

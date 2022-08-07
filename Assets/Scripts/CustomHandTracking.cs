using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Microsoft.MixedReality.Toolkit.Utilities;
using Microsoft.MixedReality.Toolkit.Input;
using Mujoco;

public class CustomHandTracking : MonoBehaviour
{
    public GameObject sphereMarker;

    GameObject thumbObject;
    GameObject indexObject;
    GameObject middleObject;
    GameObject ringObject;
    GameObject pinkyObject;
    GameObject thumbObjectDostal;
    GameObject indexObjectDostal;
    GameObject middleObjectDostal;
    GameObject ringObjectDostal;
    GameObject pinkyObjectDostal;
    GameObject palm;






    MixedRealityPose pose;

    

   


    void Start()
    {
        thumbObject = Instantiate(sphereMarker, this.transform);
        indexObject = Instantiate(sphereMarker, this.transform);
        middleObject = Instantiate(sphereMarker, this.transform);
        ringObject = Instantiate(sphereMarker, this.transform);
        pinkyObject = Instantiate(sphereMarker, this.transform);

        thumbObjectDostal = Instantiate(sphereMarker, this.transform);
        indexObjectDostal = Instantiate(sphereMarker, this.transform);
        middleObjectDostal = Instantiate(sphereMarker, this.transform);
        ringObjectDostal = Instantiate(sphereMarker, this.transform);
        pinkyObjectDostal = Instantiate(sphereMarker, this.transform);
        palm = Instantiate(sphereMarker, this.transform);

    }

    
    void Update()
    {
        //thumbObject.GetComponent<Renderer>().enabled = false;
        //indexObject.GetComponent<Renderer>().enabled = false;
        //middleObject.GetComponent<Renderer>().enabled = false;
        //ringObject.GetComponent<Renderer>().enabled = false;
        //pinkyObject.GetComponent<Renderer>().enabled = false;

        

        


        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbTip, Handedness.Both, out pose))
        {
            //thumbObject.GetComponent<Renderer>().enabled = true;
            thumbObject.transform.position = pose.Position;
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Both, out pose))
        {
            
            //indexObject.GetComponent<Renderer>().enabled = true;
            indexObject.transform.position = pose.Position;
            
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleTip, Handedness.Both, out pose))
        {
            //middleObject.GetComponent<Renderer>().enabled = true;
            middleObject.transform.position = pose.Position;
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingTip, Handedness.Both, out pose))
        {
            //ringObject.GetComponent<Renderer>().enabled = true;
            ringObject.transform.position = pose.Position;
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyTip, Handedness.Both, out pose))
        {
            //pinkyObject.GetComponent<Renderer>().enabled = true;
            pinkyObject.transform.position = pose.Position;
        }


        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbDistalJoint, Handedness.Both, out pose))
        {
            //thumbObject.GetComponent<Renderer>().enabled = true;
            thumbObjectDostal.transform.position = pose.Position;
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexDistalJoint, Handedness.Both, out pose))
        {

            //indexObject.GetComponent<Renderer>().enabled = true;
            indexObjectDostal.transform.position = pose.Position;

        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleDistalJoint, Handedness.Both, out pose))
        {
            //middleObject.GetComponent<Renderer>().enabled = true;
            middleObjectDostal.transform.position = pose.Position;
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingDistalJoint, Handedness.Both, out pose))
        {
            //ringObject.GetComponent<Renderer>().enabled = true;
            ringObjectDostal.transform.position = pose.Position;
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyDistalJoint, Handedness.Both, out pose))
        {
            //pinkyObject.GetComponent<Renderer>().enabled = true;
            pinkyObjectDostal.transform.position = pose.Position;
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyDistalJoint, Handedness.Both, out pose))
        {
            //pinkyObject.GetComponent<Renderer>().enabled = true;
            pinkyObjectDostal.transform.position = pose.Position;
        }


        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.Palm, Handedness.Both, out pose))
        {
            //pinkyObject.GetComponent<Renderer>().enabled = true;
            palm.transform.position = pose.Position;
        }


    }
}

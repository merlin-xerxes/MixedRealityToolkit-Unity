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
    GameObject thumbObject1;
    GameObject indexObject1;
    GameObject middleObject1;
    GameObject ringObject1;
    GameObject pinkyObject1;
    GameObject palm;






    MixedRealityPose pose;

    

   


    void Start()
    {
        thumbObject = Instantiate(sphereMarker, this.transform);
        indexObject = Instantiate(sphereMarker, this.transform);
        middleObject = Instantiate(sphereMarker, this.transform);
        ringObject = Instantiate(sphereMarker, this.transform);
        pinkyObject = Instantiate(sphereMarker, this.transform);

        thumbObject1 = Instantiate(sphereMarker, this.transform);
        indexObject1 = Instantiate(sphereMarker, this.transform);
        middleObject1 = Instantiate(sphereMarker, this.transform);
        ringObject1 = Instantiate(sphereMarker, this.transform);
        pinkyObject1 = Instantiate(sphereMarker, this.transform);
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
            thumbObject1.transform.position = pose.Position;
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexDistalJoint, Handedness.Both, out pose))
        {

            //indexObject.GetComponent<Renderer>().enabled = true;
            indexObject1.transform.position = pose.Position;

        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleDistalJoint, Handedness.Both, out pose))
        {
            //middleObject.GetComponent<Renderer>().enabled = true;
            middleObject1.transform.position = pose.Position;
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingDistalJoint, Handedness.Both, out pose))
        {
            //ringObject.GetComponent<Renderer>().enabled = true;
            ringObject1.transform.position = pose.Position;
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyDistalJoint, Handedness.Both, out pose))
        {
            //pinkyObject.GetComponent<Renderer>().enabled = true;
            pinkyObject1.transform.position = pose.Position;
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyDistalJoint, Handedness.Both, out pose))
        {
            //pinkyObject.GetComponent<Renderer>().enabled = true;
            pinkyObject1.transform.position = pose.Position;
        }


        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.Palm, Handedness.Both, out pose))
        {
            //pinkyObject.GetComponent<Renderer>().enabled = true;
            palm.transform.position = pose.Position;
        }


    }
}

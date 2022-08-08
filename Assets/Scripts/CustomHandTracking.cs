using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Microsoft.MixedReality.Toolkit.Utilities;
using Microsoft.MixedReality.Toolkit.Input;
using Mujoco;

public class CustomHandTracking : MonoBehaviour
{
    public GameObject sphereMarker;

    GameObject thumbObjectR;
    GameObject indexObjectR;
    GameObject middleObjectR;
    GameObject ringObjectR;
    GameObject pinkyObjectR;
    GameObject thumbObjectDostalR;
    GameObject indexObjectDostalR;
    GameObject middleObjectDostalR;
    GameObject ringObjectDostalR;
    GameObject pinkyObjectDostalR;
    GameObject palmR;


    GameObject thumbObjectL;
    GameObject indexObjectL;
    GameObject middleObjectL;
    GameObject ringObjectL;
    GameObject pinkyObjectL;
    GameObject thumbObjectDostalL;
    GameObject indexObjectDostalL;
    GameObject middleObjectDostalL;
    GameObject ringObjectDostalL;
    GameObject pinkyObjectDostalL;
    GameObject palmL;






    MixedRealityPose pose;

    

   


    void Start()
    {
        thumbObjectR = Instantiate(sphereMarker, this.transform);
        indexObjectR = Instantiate(sphereMarker, this.transform);
        middleObjectR = Instantiate(sphereMarker, this.transform);
        ringObjectR = Instantiate(sphereMarker, this.transform);
        pinkyObjectR = Instantiate(sphereMarker, this.transform);

        thumbObjectDostalR = Instantiate(sphereMarker, this.transform);
        indexObjectDostalR = Instantiate(sphereMarker, this.transform);
        middleObjectDostalR = Instantiate(sphereMarker, this.transform);
        ringObjectDostalR = Instantiate(sphereMarker, this.transform);
        pinkyObjectDostalR = Instantiate(sphereMarker, this.transform);
        palmR = Instantiate(sphereMarker, this.transform);


        thumbObjectL = Instantiate(sphereMarker, this.transform);
        indexObjectL = Instantiate(sphereMarker, this.transform);
        middleObjectL = Instantiate(sphereMarker, this.transform);
        ringObjectL = Instantiate(sphereMarker, this.transform);
        pinkyObjectL = Instantiate(sphereMarker, this.transform);

        thumbObjectDostalL = Instantiate(sphereMarker, this.transform);
        indexObjectDostalL = Instantiate(sphereMarker, this.transform);
        middleObjectDostalL = Instantiate(sphereMarker, this.transform);
        ringObjectDostalL = Instantiate(sphereMarker, this.transform);
        pinkyObjectDostalL = Instantiate(sphereMarker, this.transform);
        palmL = Instantiate(sphereMarker, this.transform);

    }

    
    void Update()
    {
        

        

        


        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbTip, Handedness.Right, out pose))
        {
            //thumbObject.GetComponent<Renderer>().enabled = true;
            thumbObjectR.transform.position = pose.Position;
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Right, out pose))
        {
            
            //indexObject.GetComponent<Renderer>().enabled = true;
            indexObjectR.transform.position = pose.Position;
            
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleTip, Handedness.Right, out pose))
        {
            //middleObject.GetComponent<Renderer>().enabled = true;
            middleObjectR.transform.position = pose.Position;
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingTip, Handedness.Right, out pose))
        {
            //ringObject.GetComponent<Renderer>().enabled = true;
            ringObjectR.transform.position = pose.Position;
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyTip, Handedness.Right, out pose))
        {
            //pinkyObject.GetComponent<Renderer>().enabled = true;
            pinkyObjectR.transform.position = pose.Position;
        }


        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbProximalJoint, Handedness.Right, out pose))
        {
            //thumbObject.GetComponent<Renderer>().enabled = true;
            thumbObjectDostalR.transform.position = pose.Position;
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexMiddleJoint, Handedness.Right, out pose))
        {

            //indexObject.GetComponent<Renderer>().enabled = true;
            indexObjectDostalR.transform.position = pose.Position;

        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleMiddleJoint, Handedness.Right, out pose))
        {
            //middleObject.GetComponent<Renderer>().enabled = true;
            middleObjectDostalR.transform.position = pose.Position;
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingMiddleJoint, Handedness.Right, out pose))
        {
            //ringObject.GetComponent<Renderer>().enabled = true;
            ringObjectDostalR.transform.position = pose.Position;
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyMiddleJoint, Handedness.Right, out pose))
        {
            //pinkyObject.GetComponent<Renderer>().enabled = true;
            pinkyObjectDostalR.transform.position = pose.Position;
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.Palm, Handedness.Right, out pose))
        {
            //pinkyObject.GetComponent<Renderer>().enabled = true;
            palmR.transform.position = pose.Position;
        }



        //--------------------------------------------------------------

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbTip, Handedness.Left, out pose))
        {
            //thumbObject.GetComponent<Renderer>().enabled = true;
            thumbObjectL.transform.position = pose.Position;
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Left, out pose))
        {

            //indexObject.GetComponent<Renderer>().enabled = true;
            indexObjectL.transform.position = pose.Position;

        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleTip, Handedness.Left, out pose))
        {
            //middleObject.GetComponent<Renderer>().enabled = true;
            middleObjectL.transform.position = pose.Position;
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingTip, Handedness.Left, out pose))
        {
            //ringObject.GetComponent<Renderer>().enabled = true;
            ringObjectL.transform.position = pose.Position;
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyTip, Handedness.Left, out pose))
        {
            //pinkyObject.GetComponent<Renderer>().enabled = true;
            pinkyObjectL.transform.position = pose.Position;
        }


        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbProximalJoint, Handedness.Left, out pose))
        {
            //thumbObject.GetComponent<Renderer>().enabled = true;
            thumbObjectDostalL.transform.position = pose.Position;
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexMiddleJoint, Handedness.Left, out pose))
        {

            //indexObject.GetComponent<Renderer>().enabled = true;
            indexObjectDostalL.transform.position = pose.Position;

        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleMiddleJoint, Handedness.Left, out pose))
        {
            //middleObject.GetComponent<Renderer>().enabled = true;
            middleObjectDostalL.transform.position = pose.Position;
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingMiddleJoint, Handedness.Left, out pose))
        {
            //ringObject.GetComponent<Renderer>().enabled = true;
            ringObjectDostalL.transform.position = pose.Position;
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyMiddleJoint, Handedness.Left, out pose))
        {
            //pinkyObject.GetComponent<Renderer>().enabled = true;
            pinkyObjectDostalL.transform.position = pose.Position;
        }


        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.Palm, Handedness.Left, out pose))
        {
            //pinkyObject.GetComponent<Renderer>().enabled = true;
            palmL.transform.position = pose.Position;
        }


    }
}

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

    public MjActuator xController;
    public MjActuator yController;

    MixedRealityPose pose;
    
    void Start()
    {
        thumbObject = Instantiate(sphereMarker, this.transform);
        indexObject = Instantiate(sphereMarker, this.transform);
        middleObject = Instantiate(sphereMarker, this.transform);
        ringObject = Instantiate(sphereMarker, this.transform);
        pinkyObject = Instantiate(sphereMarker, this.transform);
    }

    
    void Update()
    {
        thumbObject.GetComponent<Renderer>().enabled = false;
        indexObject.GetComponent<Renderer>().enabled = false;
        middleObject.GetComponent<Renderer>().enabled = false;
        ringObject.GetComponent<Renderer>().enabled = false;
        pinkyObject.GetComponent<Renderer>().enabled = false;

        Vector3 directionVector = indexObject.transform.position - pose.Position;
        float controlValue = 3;

        xController.Control = controlValue;


        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbTip, Handedness.Right, out pose))
        {
            thumbObject.GetComponent<Renderer>().enabled = true;
            thumbObject.transform.position = pose.Position;
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Right, out pose))
        {
            indexObject.GetComponent<Renderer>().enabled = true;
            indexObject.transform.position = pose.Position;
            //GameObject index = GameObject.FindGameObjectWithTag("Player");
            //index.transform.position = Vector3.MoveTowards(transform.position,pose.Position, 0.03f*Time.deltaTime);
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleTip, Handedness.Right, out pose))
        {
            middleObject.GetComponent<Renderer>().enabled = true;
            middleObject.transform.position = pose.Position;
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingTip, Handedness.Right, out pose))
        {
            ringObject.GetComponent<Renderer>().enabled = true;
            ringObject.transform.position = pose.Position;
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyTip, Handedness.Right, out pose))
        {
            pinkyObject.GetComponent<Renderer>().enabled = true;
            pinkyObject.transform.position = pose.Position;
        }
    }
}

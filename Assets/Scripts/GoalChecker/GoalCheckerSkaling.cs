using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCheckerSkaling : MonoBehaviour
{

    public GameObject checkboxCheck;
    public GameObject cubeInteract;
    public GameObject cubeGoal;

    public float threshold;
    void Start()
    {
        
    }

    
    void Update()
    {

        if(cubeInteract.transform.localScale == (cubeGoal.transform.localScale + new Vector3(threshold, threshold, threshold)) || cubeInteract.transform.localScale == (cubeGoal.transform.localScale - new Vector3(threshold, threshold, threshold)))
        {
            checkboxCheck.SetActive(true);
        }
        else
        {
            checkboxCheck.SetActive(false);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCheckerSkaling : MonoBehaviour
{

    public GameObject checkboxCheck;
    public GameObject cubeInteract;
    public GameObject cubeGoal;

    public float threshold;
    

    
    void Update()
    {

        if(cubeInteract.transform.localScale.x <= (cubeGoal.transform.localScale.x + threshold) && cubeInteract.transform.localScale.x >= (cubeGoal.transform.localScale.x - threshold)
            && cubeInteract.transform.localScale.y <= (cubeGoal.transform.localScale.y + threshold) && cubeInteract.transform.localScale.y >= (cubeGoal.transform.localScale.y - threshold)
            && cubeInteract.transform.localScale.z <= (cubeGoal.transform.localScale.z + threshold) && cubeInteract.transform.localScale.z >= (cubeGoal.transform.localScale.z - threshold))
        {
            checkboxCheck.SetActive(true);
        }
        else
        {
            checkboxCheck.SetActive(false);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCheckerBox: MonoBehaviour
{

    public GameObject checkboxCheck;
    private int counter = 0;

    void Start()
    {
        
        
    }

    
    void Update()
    {
        if (counter == 3)
            checkboxCheck.SetActive(true);

        if (counter != 3)
            checkboxCheck.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Würfel")
            counter++;
            Debug.Log("in trigger");
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Würfel")
            counter--;
            Debug.Log("out trigger");
    }


    
}

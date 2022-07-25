using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCheckerBasketball : MonoBehaviour
{
    public GameObject checkbox;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Basketball")
        {
            checkbox.SetActive(true);
            Debug.Log("Point made");
        }
        
    }

    private void OnTriggerExit(Collider other) 
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderCounter : MonoBehaviour
{
    private int collideCounter = 0;
    public GoalTracker gt;
    public Text counterText;

    private void Start() 
    {
        counterText.text = "Counter:  " + collideCounter + "/3";
    }
    
    public void Increment()
    {
        collideCounter++;
        counterText.text = "Counter:  " + collideCounter + "/3";
        if(collideCounter == 3)
        {
            gt.Complete();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderCounter : MonoBehaviour
{
    private int collideCounter = 0;
    public Text myUitext;

    public void Start() {
        myUitext.text = "0";
    }
    
    public void Increment()
    {
    collideCounter++;
    myUitext.text = collideCounter + "";
    }
}

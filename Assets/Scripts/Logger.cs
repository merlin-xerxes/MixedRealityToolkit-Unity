using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;

public class Logger : MonoBehaviour
{

    protected string header;
    
    void Start()
    {
        
    }

    public string GetHeader()
    {
        return header;
    }

    public virtual List<string> GetData()
    {
        //eigentliche Implementierung in den Kindklassen
        return null;
    }

    public virtual void WriteData()
    {
        //eigentliche Implementierung in den Kindklassen
    }

    public virtual List<string> Stringify()
    {
        //eigentliche Implementierung in den Kindklassen
        return null;
    }

    
}

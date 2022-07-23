using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logger : MonoBehaviour
{

    protected List<string> header;
    void Start()
    {
        
    }

    public List<string> GetHeader()
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

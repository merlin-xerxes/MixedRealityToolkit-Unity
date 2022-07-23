using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoggingManager : MonoBehaviour
{
    [SerializeField]
    private static string LOGFILE_DIRECTORY;
    [SerializeField]
    private static string LOGFILE_NAMEBASE;

    public List<Logger> logger;

    public bool isLogging;

    public float loggingTimeStep;
    void Start()
    {
        InvokeRepeating("NotifyLogger", 2.0f, loggingTimeStep);
    }

    private void WriteToLog()
    {

    }

    private void NotifyLogger()
    {
        foreach (Logger log in logger)
        {
            log.WriteData();
        }
    }
}

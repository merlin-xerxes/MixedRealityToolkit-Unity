using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class LoggingManager : MonoBehaviour
{
    [SerializeField]
    private static string LOGFILE_DIRECTORY = "Assets/Logs";
    [SerializeField]
    private static string LOGFILE_NAMEBASE = "logging_file.csv";

    public List<Logger> logger;

    public bool isLogging;

    private string logFile;

    public float loggingTimeStep;

    private List<string> loggerData = new List<string>();

    string allHeader = "";
    void Start()
    {
        if (isLogging) {
            //�berpr�ft, ob der Speicherort existiert und erstellt gegenfalls den entsprechenden Ordner
            if (!Directory.Exists(LOGFILE_DIRECTORY)) Directory.CreateDirectory(LOGFILE_DIRECTORY);

            logFile = LOGFILE_DIRECTORY
                    + "/"
                    //+ System.DateTime.UtcNow.ToString(LOGFILE_NAME_TIME_FORMAT)
                    //+ System.DateTime.UtcNow.AddHours(2.0).ToString(LOGFILE_NAME_TIME_FORMAT)	// manually adjust time zone, e.g. + 2 UTC hours for summer time in location Stockholm/Sweden
                    + SceneManager.GetActiveScene().name
                    + "_"
                    + LOGFILE_NAMEBASE;
            File.Create(logFile);

            if (File.Exists(logFile))
            {
                Debug.Log("[LoggingSystem] Log wurde erstellt bei " + logFile);
                InvokeRepeating("NotifyLogger", 2.0f, loggingTimeStep);
            }
            else Debug.LogError("[LoggingSystem] Loggingdatei konnte nicht erstellt werden");

        }
    }

    //Methode, die Zeile f�r Zeile, alle Daten aus den Loggern ausliest und in die loggerData Liste schreibt.
    //Au�erdem wird vor jede zeile ein Timestamp geschrieben.
    private void WriteLogData()
    {
        //string line = System.DateTime.Now + ";";
        string line;
        for(int i = 0; i < logger[0].GetData().Count; i++)
        {
            line = loggerData[i];
            foreach (Logger log in logger)
            {
                line += log.GetData()[i] + ";";
            }
            //loggerData.Add(line);
            loggerData[i] = line;
            //line = System.DateTime.Now + ";";
        }
        
    }
    

    private void WriteToLog()
    {
        if (isLogging)
        {
            if (File.Exists(logFile))
            {
                foreach (Logger log in logger)
                {
                    allHeader += log.GetHeader() + ";";
                }

                TextWriter tw = new StreamWriter(logFile, true);
                tw.WriteLine("Timestamp; " + allHeader);

                for(int i = 0; i < loggerData.Count; i++)
                {
                    tw.WriteLine(loggerData[i]);
                }


                tw.Close();
            }
        }
    }

    private void NotifyLogger()
    {
        if (isLogging)
        {
            loggerData.Add(System.DateTime.Now.ToString() + ";");
            foreach (Logger log in logger)
            {
                log.WriteData();
            }
        }
    }

    public void OnApplicationQuit()
    {
        if (isLogging)
        {
            WriteLogData();
            WriteToLog();
            Debug.Log("[LOGGING_MANAGER]: Logdatei wurde erfolgreich beschrieben");
        }
    }
}

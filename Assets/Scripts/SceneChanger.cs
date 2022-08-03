using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.SceneSystem;
using Microsoft.MixedReality.Toolkit;
using UnityEngine.SceneManagement;
using System;

public class SceneChanger : MonoBehaviour
{

    //IMixedRealitySceneSystem sceneSystem;
    
    
    public void ReloadCurrentScene()
    {
        //string currentScene = SceneManager.GetActiveScene().name;
        //SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        //SceneManager.LoadSceneAsync("StartMenu");
        //SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        //await sceneSystem.LoadContent(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name, LoadSceneMode.Single);
    }

    public void LoadScenebyName(string name)
    {
        
        //Debug.Log("aktuelle Szene: " + SceneManager.GetActiveScene().name);
        //SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        //await sceneSystem.LoadContent(name, LoadSceneMode.Single);
        SceneManager.LoadScene(name);
        Debug.Log("Szene erfolgreich geladen");
        //SceneManager.SetActiveScene(SceneManager.GetSceneByName(name));
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
            
        Debug.Log("Wechsel abgeschlossen");

    }

    public void QuitApp()
    {
        Application.Quit();
    }
}

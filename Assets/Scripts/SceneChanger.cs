using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.SceneSystem;
using Microsoft.MixedReality.Toolkit;
using UnityEngine.SceneManagement;
using System;
using Mujoco;

public class SceneChanger : MonoBehaviour
{

    //IMixedRealitySceneSystem sceneSystem;
    [SerializeField]
    [Tooltip("Name of the scene to be loaded when the button is selected.")]
    private string SceneToBeLoaded = "";

    [SerializeField]
    [Tooltip("Timeout in seconds before new scene is loaded.")]
    private float waitTimeInSecBeforeLoading = 0.25f;

    public void LoadScene()
    {
        if(GameObject.Find("MjScene") != null)
        {
            //GameObject.Find("MjScene").SetActive(false);
        }
        LoadScene(SceneToBeLoaded);     
    }

    public void LoadScene(string sceneName)
    {
        if (!string.IsNullOrWhiteSpace(sceneName))
        {
            StartCoroutine(LoadNewScene(sceneName));
        }
        else
        {
            Debug.Log($"Unsupported scene name: {sceneName}");
        }
    }

    public static string lastSceneLoaded = "";
    private IEnumerator LoadNewScene(string sceneName)
    {
        

        // Let's find out the name of the currently loaded additive scene to unload
        if (SceneManager.sceneCount > 1)
        {
            lastSceneLoaded = SceneManager.GetSceneAt(1).name;

            Debug.Log($"Last scene name: {lastSceneLoaded}");

            // Let's wait in case we don't want to switch scenes too abruptly 
            yield return new WaitForSeconds(waitTimeInSecBeforeLoading);

            SceneManager.UnloadSceneAsync(lastSceneLoaded);
        }

        Debug.Log($"New scene name: {SceneToBeLoaded}");
        lastSceneLoaded = SceneToBeLoaded;
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
    }




    public void QuitApp()
    {
        Application.Quit();
    }
    
}

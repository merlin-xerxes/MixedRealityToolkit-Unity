using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.SceneSystem;

public class SceneChanger : MonoBehaviour
{
    IMixedRealitySceneSystem sceneSystem = MixedRealityToolkit.Instance.GetService<IMixedRealitySceneSystem>();
    public async void ReloadCurrentScene()
    {
       // SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
      await sceneSystem.LoadContent();
    }

    public void LoadScenebyName(string name)
    {
        //  SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
      await sceneSystem.LoadContent(name);

    }

    public void QuitApp()
    {
        Application.Quit();
    }
}

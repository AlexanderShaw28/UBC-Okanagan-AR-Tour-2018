using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Mapbox.Unity.Map;
using Mapbox.Unity.Utilities;
using Mapbox.Utils;

public class LoadingScreenControl : MonoBehaviour {

    public GameObject loadObj;
    public Slider slider;

    AsyncOperation async;

    public void LoadScreen(int sceneNum)
    {

        StartCoroutine(LoadingScreen(sceneNum));

    }

    IEnumerator LoadingScreen(int sceneNum)
    {
        loadObj.SetActive(true);
        async = SceneManager.LoadSceneAsync(sceneNum);
        async.allowSceneActivation = false;
       

        while(async.isDone == false)
        {
            slider.value = async.progress;
            if(async.progress == 0.9f)
            {
                slider.value = 1f;
                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }
}

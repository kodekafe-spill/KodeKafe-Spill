﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{


    public GameObject loadingScreen;
    public Slider slider;
    public Text text;

    public void LoadLevel (int sceneIndex)
    {
        StartCoroutine(LoadAsyncronously(sceneIndex));
    }


    IEnumerator LoadAsyncronously (int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);

            text.text = progress.ToString() + "%";
            slider.value = progress;

            yield return null;
        }
    }
}

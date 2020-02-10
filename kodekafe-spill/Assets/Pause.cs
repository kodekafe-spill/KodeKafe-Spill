using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsyncronously(sceneIndex));
    }


    IEnumerator LoadAsyncronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        while (!operation.isDone)
        {
            yield return null;
        }
    }
}
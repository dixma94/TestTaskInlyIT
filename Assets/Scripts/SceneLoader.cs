using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader Instance;
    public AsyncOperation asyncOperation;

    void Start()
    {
        Instance = this;
        DontDestroyOnLoad(Instance);
   
        StartCoroutine(LoadSceneCoroutine("Menu"));
    }

    public void LoadScene(string sceneName)
    {
        StartCoroutine(LoadSceneCoroutine(sceneName));
    }

    IEnumerator LoadSceneCoroutine(string sceneName)
    {
        SceneManager.LoadSceneAsync("Loading");

       
        asyncOperation =  SceneManager.LoadSceneAsync(sceneName);

        asyncOperation.allowSceneActivation = false;
        while (!asyncOperation.isDone) 
        {
            yield return null;
        }

    }

    
}

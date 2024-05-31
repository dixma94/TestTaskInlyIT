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
   
        StartCoroutine(LoadScene("Menu"));
    }

    IEnumerator LoadScene(string sceneName)
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

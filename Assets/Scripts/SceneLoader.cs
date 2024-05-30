using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private static SceneLoader Instance;

    void Start()
    {
        Instance = this;
        DontDestroyOnLoad(Instance);
   
        StartCoroutine(LoadScene("Menu"));
    }

    IEnumerator LoadScene(string sceneName)
    {
        SceneManager.LoadScene("Loading");

        yield return new WaitForSecondsRealtime(10);
        AsyncOperation operation =  SceneManager.LoadSceneAsync(sceneName);
        while (!operation.isDone) 
        {
            yield return null;
        }

    }

    
}

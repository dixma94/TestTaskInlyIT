using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingSceneController : MonoBehaviour
{
    public void OnAnimationOver()
    {
       SceneLoader.Instance.asyncOperation.allowSceneActivation = true;
    }
}

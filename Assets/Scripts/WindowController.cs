using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class WindowController : MonoBehaviour
{
    public int ID;
    public bool IsActive;
    protected SceneController sceneController;

    public void Init(SceneController sceneController)
    {
      this.sceneController = sceneController;
    }

    
}

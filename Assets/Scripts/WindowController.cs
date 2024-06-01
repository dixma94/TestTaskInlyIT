using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class WindowController : MonoBehaviour
{
    public int ID;
    public bool IsActive;
    protected CommandManager commandManager;
    protected SceneController sceneController;
    

    public void Init(CommandManager commandManager, SceneController sceneController)
    {
        this.commandManager = commandManager;
        this.sceneController = sceneController; 
    }

    
}

using System;
using UnityEngine;
using UnityEngine.UI;

public abstract class WindowController : MonoBehaviour
{
    public int ID;
    public bool IsActive;
    virtual public event Action<string> OnOpened;
    protected CommandManager commandManager;
    protected SceneController sceneController;

    [SerializeField] protected Button CloseButton;

  

    public void Init(CommandManager commandManager, SceneController sceneController)
    {
        this.commandManager = commandManager;
        this.sceneController = sceneController;
    }

    protected virtual void CloseWindow()
    {
        commandManager.ExecuteCommand(new CloseWindowCommand(sceneController,ID));
        Destroy(gameObject);
    }
    
}

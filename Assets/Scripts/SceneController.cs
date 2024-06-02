using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour, ISceneController
{
    [SerializeField] private WindowRepository windowRepository;

    private Dictionary<int, WindowController> OpenedWindowsMap = new Dictionary<int, WindowController>();

    private CommandManager commandManager;

    private void Awake()
    {
        commandManager = new CommandManager();
    }

    private void Start()
    {
       
        OpenWindow(0);
    }

    public void OpenWindow(int ID)
    {
        WindowController windowController = windowRepository.GetWindow(ID);
        OpenedWindowsMap.Add(ID, windowController);
        windowController = Instantiate(windowController);
        windowController.IsActive = true;
        windowController.Init(commandManager,this);
    }


    public void CloseWindow(int ID)
    {
        if (OpenedWindowsMap.ContainsKey(ID))
        {
            OpenedWindowsMap[ID].IsActive = false;
            Destroy(OpenedWindowsMap[ID].gameObject);
            OpenedWindowsMap.Remove(ID);
        }
    }
}

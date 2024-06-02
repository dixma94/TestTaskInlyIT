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
        windowController.OnOpened += OnOpenedWindow;
    }

    private void OnOpenedWindow(string log)
    {
        Debug.Log(log);
    }

    public void CloseWindow(int ID)
    {
        if (OpenedWindowsMap.ContainsKey(ID))
        {
            WindowController windowController = OpenedWindowsMap[ID];
            windowController.IsActive = false;
            OpenedWindowsMap.Remove(ID);
        }
       
    }

}

public abstract class SceneControllerDecorator : ISceneController
{
    protected ISceneController sceneController;

    protected SceneControllerDecorator(ISceneController sceneController)
    {
        this.sceneController = sceneController;
    }

    public abstract void CloseWindow(int ID);
    public abstract void OpenWindow(int ID);
}

public class SceneControlWithLog : SceneControllerDecorator
{
    public SceneControlWithLog(ISceneController sceneController) : base(sceneController)
    {
    }

    public override void CloseWindow(int ID)
    {
        sceneController.CloseWindow(ID);
        Debug.Log("Close " + ID);
    }

    public override void OpenWindow(int ID)
    {
        sceneController.OpenWindow(ID);
        Debug.Log("Open " + ID);
    }
}

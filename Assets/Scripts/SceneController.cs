using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour, ISceneController
{
    [SerializeField] private WindowRepository windowRepository;

    private Dictionary<int, WindowController> OpenedWindowsMap = new Dictionary<int, WindowController>();


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
        windowController.Init(this);
        Debug.Log("Open");
    }

    private void WindowController_OpenAnotherWindow(int obj)
    {
        Debug.Log(obj);
    }

    public void CloseWindow(int ID)
    {
        if (OpenedWindowsMap.ContainsKey(ID))
        {
            OpenedWindowsMap[ID].IsActive = false;
            Destroy(OpenedWindowsMap[ID].gameObject);
            OpenedWindowsMap.Remove(ID);
        }
        Debug.Log("Close");
    }
}

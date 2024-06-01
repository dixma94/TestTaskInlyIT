using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WindowRepository", menuName = "ScriptableObjects/WindowRepository", order = 1)]
public class WindowRepository: ScriptableObject
{
    public List<WindowController> Windows;

    private Dictionary<int,WindowController> windowsMap = new Dictionary<int, WindowController>();

    private void OnValidate()
    {
        foreach (WindowController windowController in Windows)
        {
            if (!windowsMap.ContainsKey(windowController.ID))
            {
                windowsMap.Add(windowController.ID, windowController);
            }
        }
       
    }

    public WindowController GetWindow(int ID)
    {
        return windowsMap[ID];
    }
}
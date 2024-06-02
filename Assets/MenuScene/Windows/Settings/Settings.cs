using UnityEngine.UI;

public class Settings : WindowController
{

    public Button SettingsButton;



    private void OnEnable()
    {
        SettingsButton.onClick.AddListener(someMethod);
        CloseButton.onClick.AddListener(CloseWindow);

    }
    private void OnDisable()
    {
        SettingsButton.onClick.RemoveAllListeners();
        CloseButton.onClick.RemoveAllListeners();
    }
   

    private void someMethod()
    {
        
    }

}
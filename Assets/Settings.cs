using UnityEngine.UI;

public class Settings : WindowController
{

    public Button SettingsButton;


    private void OnEnable()
    {
        SettingsButton.onClick.AddListener(someMethod);
       
    }
    private void OnDisable()
    {
        SettingsButton.onClick.RemoveAllListeners();
      
    }
   

    private void someMethod()
    {
        
    }

}
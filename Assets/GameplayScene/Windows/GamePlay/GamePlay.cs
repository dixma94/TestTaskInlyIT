using UnityEngine.UI;

public class GamePlay : WindowController
{
    
    public Button PauseButton;

    private void OnEnable()
    {
        PauseButton.onClick.AddListener(PauseGame);
        CloseButton?.onClick.AddListener(CloseWindow);

    }

    private void OnDisable()
    {
        PauseButton.onClick.RemoveAllListeners();
        CloseButton?.onClick.RemoveAllListeners();
    }

    private void PauseGame()
    {
        commandManager.ExecuteCommand(new OpenWindowCommand(sceneController, 1));
    }
}

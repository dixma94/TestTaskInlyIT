

public class Choose : WindowController
{
    private void OnEnable()
    {
        CloseButton.onClick.AddListener(CloseWindow);
    }
    private void OnDisable()
    {
        CloseButton.onClick.RemoveAllListeners();
    }

    protected override void CloseWindow()
    {
        base.CloseWindow();
        commandManager.ExecuteCommand(new OpenWindowCommand(sceneController, 0));
    }
}

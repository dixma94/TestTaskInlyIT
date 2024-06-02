

using System;

public class Choose : WindowController
{
    public override event Action<string> OnOpened;

    private void Start()
    {
        OnOpened?.Invoke("Open SelectMenu");
    }

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

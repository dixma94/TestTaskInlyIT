

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

}

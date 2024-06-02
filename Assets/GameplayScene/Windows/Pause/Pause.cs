using UnityEngine.UI;

public class Pause : WindowController
{
    public Button MenuButton;

    private void OnEnable()
    {
        CloseButton.onClick.AddListener(CloseWindow);
        MenuButton.onClick.AddListener(OpenMenu);

    }

    private void OnDisable()
    {
        CloseButton.onClick.RemoveAllListeners();
        MenuButton.onClick.RemoveAllListeners();
    }

    private void OpenMenu()
    {
        SceneLoader.Instance.LoadScene("Menu");
    }
}
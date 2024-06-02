using UnityEngine.UI;

public class Menu: WindowController
{

    public Button OpenSettingsButton;
    public Button StartGameButton;
    public Button ChooseHeroButton;



    private void OnEnable()
    {
        OpenSettingsButton.onClick.AddListener(OpenSettings);
        StartGameButton.onClick.AddListener(StartGame);
        ChooseHeroButton.onClick.AddListener(ChooseHero);
    }

    private void OnDisable()
    {
        OpenSettingsButton.onClick.RemoveAllListeners();
        StartGameButton.onClick.RemoveAllListeners();
        ChooseHeroButton.onClick.RemoveAllListeners();
    }

    private void StartGame()
    {
        commandManager.ExecuteCommand(new OpenSceneCommand("GamePlay"));
    }

    private void OpenSettings()
    {
        commandManager.ExecuteCommand(new OpenWindowCommand(sceneController, 1));
     
    }

    private void ChooseHero()
    {
        commandManager.ExecuteCommand(new OpenWindowCommand(sceneController, 2));
    }
}

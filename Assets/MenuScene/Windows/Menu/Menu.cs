using System;
using UnityEngine.UI;

public class Menu: WindowController
{
    
    public Button OpenSettingsButton;
    public Button StartGameButton;
    public Button ChooseHeroButton;

    public override event Action<string> OnOpened;

    private void Start()
    {
        OnOpened?.Invoke("Open menu");
        if (DataSaveLoader.instance.IsFileExist())
        {

            StartGameButton.enabled = true;
        }
        else
        {
            StartGameButton.enabled = false;
        }
        
    }

    private void OnEnable()
    {
        OpenSettingsButton.onClick.AddListener(OpenSettings);
        StartGameButton.onClick.AddListener(StartGame);
        ChooseHeroButton.onClick.AddListener(ChooseHero);
        CloseButton?.onClick.AddListener(CloseWindow);
    }

    private void OnDisable()
    {
        OpenSettingsButton.onClick.RemoveAllListeners();
        StartGameButton.onClick.RemoveAllListeners();
        ChooseHeroButton.onClick.RemoveAllListeners();
        CloseButton?.onClick.RemoveAllListeners();
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
        CloseWindow();
        commandManager.ExecuteCommand(new OpenWindowCommand(sceneController, 2));
    }


}

using System;
using UnityEngine;
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
        SceneLoader.Instance.LoadScene("GamePlay");
    }

    private void OpenSettings()
    {
        sceneController.OpenWindow(1);
    }

    private void ChooseHero()
    {
        sceneController.OpenWindow(2);
    }
}

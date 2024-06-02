using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GamePlay : WindowController
{
    
    public Button PauseButton;

    public TextMeshProUGUI Name;
    public Image sprite;

    private GemData gemData;

    private void Start()
    {
        gemData =  DataSaveLoader.instance.Load();
        Name.text = gemData.Name;
        sprite.sprite = Resources.Load<Sprite>(gemData.spriteName);
    }

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

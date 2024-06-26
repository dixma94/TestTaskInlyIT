﻿public class OpenWindowCommand : Command
{
    SceneController sceneController;
    int IDWindow;

    public OpenWindowCommand(SceneController sceneController, int IDWindow)
    {
        this.sceneController = sceneController;
        this.IDWindow = IDWindow;
    }

    public override void Execute()
    {
        sceneController.OpenWindow(IDWindow);
    }

    public override void Undo()
    {
        sceneController.CloseWindow(IDWindow);
    }



}


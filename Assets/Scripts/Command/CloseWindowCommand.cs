public class CloseWindowCommand : Command
{
    SceneController sceneController;
    int IDWindow;

    public CloseWindowCommand(SceneController sceneController, int IDWindow)
    {
        this.sceneController = sceneController;
        this.IDWindow = IDWindow;
    }

    public override void Execute()
    {
        sceneController.CloseWindow(IDWindow);
    }

    public override void Undo()
    {
        sceneController.OpenWindow(IDWindow);
    }



}

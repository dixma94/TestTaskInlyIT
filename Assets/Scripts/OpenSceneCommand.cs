public class OpenSceneCommand : Command
{
    string SceneName;

    public OpenSceneCommand(string SceneName)
    {
        this.SceneName = SceneName;
    }

    public override void Execute()
    {
        SceneLoader.Instance.LoadScene(SceneName);
    }

    public override void Undo()
    {
        throw new System.NotImplementedException();
    }



}

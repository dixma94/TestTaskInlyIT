using System.Collections.Generic;

public class CommandManager
{
    private Stack<Command> commandStack = new Stack<Command>();

    public void ExecuteCommand(Command cmd)
    {
        cmd.Execute();
      
        commandStack.Push(cmd);
    }


    public void Undo()
    {
      
            Command cmd = commandStack.Pop();
            cmd.Undo();
        
    }
}

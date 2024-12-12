namespace command;

public interface ICommand
{
    public void Execute();
    public void Undo();
}
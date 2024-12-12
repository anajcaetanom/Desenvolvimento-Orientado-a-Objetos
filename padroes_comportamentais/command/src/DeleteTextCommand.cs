using command.editor;

namespace command.commands;

public class DeleteTextCommand : ICommand
{
    private readonly TextEditor _editor;
    private readonly int _lengthToDelete;
    private string _deleteText = string.Empty;

    public DeleteTextCommand(TextEditor editor, int lengthToDelete)
    {
        _editor = editor;
        _lengthToDelete = lengthToDelete;
    }

    public void Execute()
    {
        if (_lengthToDelete < _editor.Content.Length)
        {
            _deleteText = _editor.Content.Substring(_editor.Content.Length - _lengthToDelete);
            _editor.DeleteLast(_lengthToDelete);
        }
        else
        {
            Console.WriteLine("Not enough characters to delete.");
        }
    }

    public void Undo()
    {
        _editor.Write(_deleteText);
    }
    
}
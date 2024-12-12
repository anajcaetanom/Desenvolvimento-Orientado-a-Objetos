using command.editor;

namespace command.commands;

public class WriteTextCommand : ICommand
{
    private readonly TextEditor _editor;
    private readonly string _text;

    public WriteTextCommand(TextEditor editor, string text)
    {
        _editor = editor;
        _text = text;
    }

    public void Execute()
    {
        _editor.Write(_text);
    }

    public void Undo()
    {
        _editor.DeleteLast(_text.Length);
    }
    
}
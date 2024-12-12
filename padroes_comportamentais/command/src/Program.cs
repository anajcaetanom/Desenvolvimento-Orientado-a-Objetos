using command.commands;
using command.editor;

namespace command;

class Program
{
    static void Main(string[] args)
    {
        var editor = new TextEditor();
        var commandManager = new CommandManager();
        
        commandManager.ExecuteCommand(new WriteTextCommand(editor, "Hello, "));
        commandManager.ExecuteCommand(new WriteTextCommand(editor, "World!"));
        Console.WriteLine(editor);
        
        commandManager.ExecuteCommand(new DeleteTextCommand(editor, 6));
        Console.WriteLine(editor);
        
        commandManager.Undo();
        Console.WriteLine(editor);
        commandManager.Redo();
        Console.WriteLine(editor);
    }
}
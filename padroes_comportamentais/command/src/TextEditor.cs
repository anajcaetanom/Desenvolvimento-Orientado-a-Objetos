namespace command.editor;

public class TextEditor
{
    public string Content { get; private set; } = string.Empty;

    public void Write(string text)
    {
        this.Content += text;
    }

    public void DeleteLast(int length)
    {
        if (length <= this.Content.Length)
        {
            this.Content = this.Content.Substring(0, Content.Length - length);
        }
    }

    public override string ToString()
    {
        return this.Content;
    }
}
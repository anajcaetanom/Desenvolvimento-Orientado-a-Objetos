using System.Reflection.Metadata;

namespace chain_of_responsability;

public abstract class DocumentHandler
{
    protected DocumentHandler NextHandler;

    public DocumentHandler SetNext(DocumentHandler nextHandler)
    {
        NextHandler = nextHandler;
        return nextHandler;
    }
    
    protected abstract bool CanHandle(string documentType);
    protected abstract void Process(string documentType);

    public void Handle(string documentType)
    {
        if (CanHandle(documentType))
        {
            Process(documentType);
        }
        else if (NextHandler != null)
        {
            NextHandler.Handle(documentType);
        }
        else
        {
            Console.WriteLine($"DocumentHandler cannot handle document type {documentType}.");
        }
    }

}
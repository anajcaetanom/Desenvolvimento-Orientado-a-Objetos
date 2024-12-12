namespace chain_of_responsability;

public class ReceiptHandler : DocumentHandler
{
    protected override bool CanHandle(string documentType)
    {
        return documentType == "Receipt";
    }

    protected override void Process(string documentType)
    {
        Console.WriteLine($"Processing {documentType}...");
    }
}
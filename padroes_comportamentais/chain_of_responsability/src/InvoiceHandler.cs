namespace chain_of_responsability;

public class InvoiceHandler : DocumentHandler
{
    protected override bool CanHandle(string documentType)
    {
        return documentType == "Invoice";
    }

    protected override void Process(string documentType)
    {
        Console.WriteLine($"Processing {documentType}...");
    }
}
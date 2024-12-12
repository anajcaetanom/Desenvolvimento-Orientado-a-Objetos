namespace chain_of_responsability;

public class BillHandler : DocumentHandler
{
    protected override bool CanHandle(string documentType)
    {
        return documentType == "Bill";
    }

    protected override void Process(string documentType)
    {
        Console.WriteLine($"Processing {documentType}...");
    }
}
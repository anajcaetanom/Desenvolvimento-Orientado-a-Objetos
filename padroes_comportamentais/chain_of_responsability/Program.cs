namespace chain_of_responsability;

class Program
{
    static void Main(string[] args)
    {
        var handler = new InvoiceHandler();
        handler.SetNext(new ReceiptHandler().SetNext(new BillHandler()));
        
        handler.Handle("Invoice");
        handler.Handle("Unknown");
    }
}
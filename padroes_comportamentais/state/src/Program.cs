namespace state;

class Program
{
    static void Main(string[] args)
    {
        var vendingMachine = new VendingMachine();
        
        vendingMachine.InsertCoin();
        vendingMachine.SelectProduct();
        vendingMachine.DispenseProduct();
    }
}
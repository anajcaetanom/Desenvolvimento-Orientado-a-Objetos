namespace state;

public class HasCoinState : IState
{
    public void InsertCoin(VendingMachine vendingMachine)
    {
        Console.WriteLine("Coin already inserted.");
    }

    public void SelectProduct(VendingMachine vendingMachine)
    {
        Console.WriteLine("Product selected.");
        vendingMachine.SetState(new SoldState());
    }

    public void DispenseProduct(VendingMachine vendingMachine)
    {
        Console.WriteLine("Select a product.");
    }
}
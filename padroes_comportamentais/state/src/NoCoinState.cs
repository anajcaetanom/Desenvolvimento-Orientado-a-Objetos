namespace state;

public class NoCoinState : IState
{
    public void InsertCoin(VendingMachine vendingMachine)
    {
        Console.WriteLine("Coin inserted.");
        vendingMachine.SetState(new HasCoinState());
    }

    public void SelectProduct(VendingMachine vendingMachine)
    {
        Console.WriteLine("Insert a coin.");
    }

    public void DispenseProduct(VendingMachine vendingMachine)
    {
        Console.WriteLine("Insert a coin.");
    }
}
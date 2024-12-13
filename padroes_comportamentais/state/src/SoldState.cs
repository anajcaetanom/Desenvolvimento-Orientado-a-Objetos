namespace state;

public class SoldState : IState
{
    public void InsertCoin(VendingMachine vendingMachine)
    {
        Console.WriteLine("Wait! Dispensing product.");
    }

    public void SelectProduct(VendingMachine vendingMachine)
    {
        Console.WriteLine("Wait! Dispensing product.");
    }

    public void DispenseProduct(VendingMachine vendingMachine)
    {
        Console.WriteLine("Product dispensed.");
        vendingMachine.SetState(new NoCoinState());
    }
}
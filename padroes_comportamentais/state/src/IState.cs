namespace state;

public interface IState
{
    public void InsertCoin(VendingMachine vendingMachine);
    public void SelectProduct(VendingMachine vendingMachine);
    public void DispenseProduct(VendingMachine vendingMachine);
}
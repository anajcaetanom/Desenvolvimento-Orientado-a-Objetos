namespace state;

public class VendingMachine
{
    private IState _state;

    public VendingMachine()
    {
        _state = new NoCoinState();
    }

    public void SetState(IState state)
    {
        _state = state;
    }

    public void InsertCoin()
    {
        _state.InsertCoin(this);
    }

    public void SelectProduct()
    {
        _state.SelectProduct(this);
    }

    public void DispenseProduct()
    {
        _state.DispenseProduct(this);
    }
}
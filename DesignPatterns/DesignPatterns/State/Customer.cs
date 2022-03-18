namespace DesignPatterns.DesignPatterns.State;

public class Customer
{
    private IState _state;
    public decimal Balance { get; set; }

    public Customer() => _state = new NewState();

    public void SetState(IState state) => _state = state;
    public IState? GetState() => _state;
    public void Request(decimal amount) => _state.Action(this, amount);
    public void Discount(decimal amount) => Balance -= amount;
    public decimal AddBalance(decimal amount) => Balance += amount;
}

namespace DesignPatterns.DesignPatterns.State;

public class NewState : IState
{
    public void Action(Customer customer, decimal amount)
    {
        Console.WriteLine($"Adding {amount} to customer's balance");
        customer.AddBalance(amount);
        customer.SetState(new NotDebtorState());
    }
}

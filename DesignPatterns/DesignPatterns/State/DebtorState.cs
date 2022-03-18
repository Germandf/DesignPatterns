namespace DesignPatterns.DesignPatterns.State;

public class DebtorState : IState
{
    public void Action(Customer customer, decimal amount)
    {
        Console.WriteLine($"Can't buy because customer has Debtor State.");
    }
}

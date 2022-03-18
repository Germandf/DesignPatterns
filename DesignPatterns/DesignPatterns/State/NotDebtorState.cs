namespace DesignPatterns.DesignPatterns.State;

public class NotDebtorState : IState
{
    public void Action(Customer customer, decimal amount)
    {
        if(amount <= customer.Balance)
        {
            customer.Discount(amount);
            Console.WriteLine($"Accepted, spent {amount}, has {customer.Balance} balance left.");
            if (customer.Balance <= 0)
                customer.SetState(new DebtorState());
        }
        else
        {
            Console.WriteLine($"Denied, tried to spend {amount} having {customer.Balance} balance.");
        }
    }
}

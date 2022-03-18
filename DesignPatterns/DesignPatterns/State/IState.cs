namespace DesignPatterns.DesignPatterns.State;

public interface IState
{
    public void Action(Customer customer, decimal amount);
}

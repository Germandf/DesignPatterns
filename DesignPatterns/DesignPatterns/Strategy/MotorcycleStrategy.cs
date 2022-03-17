namespace DesignPatterns.DesignPatterns.Strategy;

public class MotorcycleStrategy : IStrategy
{
    public void Run()
    {
        Console.WriteLine("Brrum brrum but smaller");
    }
}

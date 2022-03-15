namespace DesignPatterns.FactoryMethod;

// Concrete Product
public class InternetSale : ISale
{
    private decimal _discount;

    public InternetSale(decimal discount)
    {
        _discount = discount;
    }

    public void Sell(decimal total)
    {
        Console.WriteLine($"The {nameof(InternetSale)} has a total of {total - _discount}");
    }
}

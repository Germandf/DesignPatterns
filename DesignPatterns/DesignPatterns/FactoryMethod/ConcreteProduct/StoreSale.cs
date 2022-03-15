namespace DesignPatterns.FactoryMethod;

// Concrete Product
public class StoreSale : ISale
{
    private decimal _extra;

    public StoreSale(decimal extra)
    {
        _extra = extra;
    }

    public void Sell(decimal total)
    {
        Console.WriteLine($"The {nameof(StoreSale)} has a total of {total + _extra}");
    }
}

namespace DesignPatterns.FactoryMethod;

// Concrete Creator
public class InternetSaleSite : SaleSite
{
    private decimal _discount;

    public InternetSaleSite(decimal discount)
    {
        _discount = discount;
    }

    public override ISale GetSale()
    {
        return new StoreSale(_discount);
    }
}
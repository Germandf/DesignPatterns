namespace DesignPatterns.FactoryMethod;

// Concrete Creator
public class StoreSaleSite : SaleSite
{
    private decimal _extra;

    public StoreSaleSite(decimal extra)
    {
        _extra = extra;
    }

    public override ISale GetSale()
    {
        return new StoreSale(_extra);
    }
}

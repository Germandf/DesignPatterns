namespace DesignPatterns.DependencyInjection;

public class Processor
{
    private string _name;
    private string _brand;

    public Processor(string name, string brand)
    {
        _name = name;
        _brand = brand;
    }
}

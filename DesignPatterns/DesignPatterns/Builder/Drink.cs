namespace DesignPatterns.DesignPatterns.Builder;

public class Drink
{
    public List<string> Ingredients { get; set; } = new();
    public int Milk { get; set; }
    public int Water { get; set; }
    public decimal Alcohol { get; set; }
    public string? Result { get; set; }
}

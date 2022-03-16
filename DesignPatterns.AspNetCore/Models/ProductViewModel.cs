namespace DesignPatterns.AspNetCore.Models;

public class ProductViewModel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
}

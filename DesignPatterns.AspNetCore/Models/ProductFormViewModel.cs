using System.ComponentModel.DataAnnotations;

namespace DesignPatterns.AspNetCore.Models;

public class ProductFormViewModel
{
    [Required]
    public string Name { get; set; } = null!;
    [Required]
    public string Description { get; set; } = null!;
    public int? BrandId { get; set; }
    public string? OtherBrand { get; set; }
}

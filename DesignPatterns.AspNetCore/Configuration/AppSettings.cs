namespace DesignPatterns.AspNetCore.Configuration;

public class AppSettings
{
    public string PathLog { get; set; } = null!;
    public decimal LocalPercentage { get; set; }
    public decimal ForeignPercentage { get; set; }
    public decimal Extra { get; set; }
}

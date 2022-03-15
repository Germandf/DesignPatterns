using DesignPatterns.Models;
using Microsoft.EntityFrameworkCore;

namespace DesignPatterns.DesignPatterns.Repository;

public class ProductRepository : IProductRepository
{
    private readonly DesignPatternsContext _context;

    public ProductRepository(DesignPatternsContext context) =>
        _context = context;

    public void Add(Product product) =>
        _context.Products.Add(product);

    public void Delete(int id) =>
        _context.Products.Remove(_context.Products.Find(id)!);

    public IEnumerable<Product> Get() =>
        _context.Products;

    public Product? Get(int id) =>
        _context.Products.Find(id);

    public void Save() =>
        _context.SaveChanges();

    public void Update(Product product) =>
        _context.Entry(product).State = EntityState.Modified;
    
}

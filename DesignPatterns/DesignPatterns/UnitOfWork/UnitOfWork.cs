using DesignPatterns.DesignPatterns.Repository;
using DesignPatterns.Models;

namespace DesignPatterns.DesignPatterns.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly DesignPatternsContext _context;
    private IRepository<Product>? _products;
    private IRepository<Brand>? _brands;

    public UnitOfWork(DesignPatternsContext context) =>
        _context = context;

    public IRepository<Product> Products
    {
        get
        {
            return _products is null ? _products = new Repository<Product>(_context) : _products;
        }
    }

    public IRepository<Brand> Brands
    {
        get
        {
            return _brands is null ? _brands = new Repository<Brand>(_context) : _brands;
        }
    }

    public void Save() =>
        _context.SaveChanges();
}

using DesignPatterns.DesignPatterns.Repository;
using DesignPatterns.Models;

namespace DesignPatterns.DesignPatterns.UnitOfWork;

public interface IUnitOfWork
{
    public IRepository<Product> Products { get; }
    public IRepository<Brand> Brands { get; }

    public void Save();
}

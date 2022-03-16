using DesignPatterns.Models.Data;

namespace DesignPatterns.Repository;

public interface IUnitOfWork
{
    public IRepository<Product> Products { get; }
    public IRepository<Brand> Brands { get; }

    public void Save();
}

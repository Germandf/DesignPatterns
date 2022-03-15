using DesignPatterns.Models;

namespace DesignPatterns.DesignPatterns.Repository;

public interface IProductRepository
{
    IEnumerable<Product> Get();
    Product? Get(int id);
    void Add(Product product);
    void Delete(int id);
    void Update(Product product);
    void Save();
}

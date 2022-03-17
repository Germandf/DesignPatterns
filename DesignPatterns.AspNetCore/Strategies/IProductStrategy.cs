using DesignPatterns.AspNetCore.Models;
using DesignPatterns.Repository;

namespace DesignPatterns.AspNetCore.Strategies;

public interface IProductStrategy
{
    void Add(ProductFormViewModel productFormViewModel, IUnitOfWork unitOfWork);
}

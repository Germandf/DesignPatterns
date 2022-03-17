using DesignPatterns.AspNetCore.Models;
using DesignPatterns.Repository;

namespace DesignPatterns.AspNetCore.Strategies;

public class ProductContext
{
    public IProductStrategy ProductStrategy
    {
        set
        {
            _productStrategy = value;
        }
    }
    
    private IProductStrategy _productStrategy;
    
    public ProductContext(IProductStrategy productStrategy)
    {
        _productStrategy = productStrategy;
    }

    public void Add(ProductFormViewModel productFormViewModel, IUnitOfWork unitOfWork)
    {
        _productStrategy.Add(productFormViewModel, unitOfWork);
    }
}

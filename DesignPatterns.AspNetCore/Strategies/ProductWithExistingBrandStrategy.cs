using DesignPatterns.AspNetCore.Models;
using DesignPatterns.Models.Data;
using DesignPatterns.Repository;

namespace DesignPatterns.AspNetCore.Strategies;

public class ProductWithExistingBrandStrategy : IProductStrategy
{
    public void Add(ProductFormViewModel productFormViewModel, IUnitOfWork unitOfWork)
    {
        var product = new Product() { Name = productFormViewModel.Name, Description = productFormViewModel.Description };
        product.Brand = unitOfWork.Brands.Get().FirstOrDefault(x => x.Id == productFormViewModel.BrandId);
        unitOfWork.Products.Add(product);
        unitOfWork.Save();
    }
}

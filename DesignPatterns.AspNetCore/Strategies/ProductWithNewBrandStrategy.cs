using DesignPatterns.AspNetCore.Models;
using DesignPatterns.Models.Data;
using DesignPatterns.Repository;

namespace DesignPatterns.AspNetCore.Strategies
{
    public class ProductWithNewBrandStrategy : IProductStrategy
    {
        public void Add(ProductFormViewModel productFormViewModel, IUnitOfWork unitOfWork)
        {
            var product = new Product() { Name = productFormViewModel.Name, Description = productFormViewModel.Description };
            var brand = new Brand() { Name = productFormViewModel.OtherBrand };
            product.Brand = brand;
            unitOfWork.Products.Add(product);
            unitOfWork.Save();
        }
    }
}

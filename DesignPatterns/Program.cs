using DesignPatterns.DesignPatterns.Repository;
using DesignPatterns.DesignPatterns.UnitOfWork;
using DesignPatterns.Models;

Console.WriteLine("Hello world!");

using (var context = new DesignPatternsContext())
{
    var productRepository = new ProductRepository(context);
    var productToAdd = new Product() { Name = "Smartphone", Description="Cheap and powerfull" };
    productRepository.Add(productToAdd);
    productRepository.Save();
    foreach (var product in productRepository.Get())
    {
        Console.WriteLine(product.Name);
    }

    var brandRepository = new Repository<Brand>(context);
    var brandToAdd = new Brand { Name = "Xiaomi" };
    brandRepository.Add(brandToAdd);
    brandRepository.Save();
    foreach (var brand in brandRepository.Get())
    {
        Console.WriteLine(brand.Name);
    }

    var unitOfWork = new UnitOfWork(context);

    var products = unitOfWork.Products;
    var productToAdd2 = new Product() { Name = "Tv", Description = "Normal" };
    products.Add(productToAdd2);

    var brands = unitOfWork.Brands;
    var brandToAdd2 = new Brand() { Name = "Logitech" };
    brands.Add(brandToAdd2);

    unitOfWork.Save();
}
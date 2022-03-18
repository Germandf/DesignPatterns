using DesignPatterns.DesignPatterns.Builder;
using DesignPatterns.DesignPatterns.Repository;
using DesignPatterns.DesignPatterns.Strategy;
using DesignPatterns.DesignPatterns.UnitOfWork;
using DesignPatterns.Models;

Console.WriteLine("Hello world!");

using (var dpContext = new DesignPatternsContext())
{
    var productRepository = new ProductRepository(dpContext);
    var productToAdd = new Product() { Name = "Smartphone", Description="Cheap and powerfull" };
    productRepository.Add(productToAdd);
    productRepository.Save();
    foreach (var product in productRepository.Get())
    {
        Console.WriteLine(product.Name);
    }

    var brandRepository = new Repository<Brand>(dpContext);
    var brandToAdd = new Brand { Name = "Xiaomi" };
    brandRepository.Add(brandToAdd);
    brandRepository.Save();
    foreach (var brand in brandRepository.Get())
    {
        Console.WriteLine(brand.Name);
    }

    var unitOfWork = new UnitOfWork(dpContext);

    var products = unitOfWork.Products;
    var productToAdd2 = new Product() { Name = "Tv", Description = "Normal" };
    products.Add(productToAdd2);

    var brands = unitOfWork.Brands;
    var brandToAdd2 = new Brand() { Name = "Logitech" };
    brands.Add(brandToAdd2);

    unitOfWork.Save();
}

var context = new Context(new CarStrategy());
context.Run();
context.Strategy = new MotorcycleStrategy();
context.Run();

var builder = new AlcoholicDrinkConcreteBuilder();
var barmanDirector = new BarmanDirector(builder);
barmanDirector.PrepareMargarita();
var drink = builder.GetDrink();
Console.WriteLine(drink.Result);
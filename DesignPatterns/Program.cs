using DesignPatterns.DesignPatterns.Repository;
using DesignPatterns.Tools;

Console.WriteLine("Hello world!");

using (var context = new DesignPatternsContext())
{
    var productRepository = new ProductRepository(context);
    var productToAdd = new Product() { Name = "Celular", Description="Muy caro" };
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

}
using DesignPatterns.Repository;
using DesignPatterns.Tools.Builder;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.AspNetCore.Controllers;

public class GeneratorController : Controller
{
    private IUnitOfWork _unitOfWork;
    private GeneratorConcreteBuilder _generatorConcreteBuilder;

    public GeneratorController(IUnitOfWork unitOfWork, GeneratorConcreteBuilder generatorConcreteBuilder)
    {
        _unitOfWork = unitOfWork;
        _generatorConcreteBuilder = generatorConcreteBuilder;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult CreateFile(int optionFile)
    {
        try
        {
            var products = _unitOfWork.Products.Get();
            var content = products.Select(x => x.Name).ToList();
            var path = "file" + DateTime.Now.Ticks + Random.Shared.Next(1000) + ".txt";
            var generatorDirector = new GeneratorDirector(_generatorConcreteBuilder);
            if (optionFile == 1)
                generatorDirector.CreateSimpleJson(content, path);
            else
                generatorDirector.CreateSimplePipe(content, path);
            var generator = _generatorConcreteBuilder.GetGenerator();
            generator.Save();
            return Json("File generated");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}

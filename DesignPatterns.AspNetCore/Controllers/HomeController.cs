using DesignPatterns.AspNetCore.Configuration;
using DesignPatterns.AspNetCore.Models;
using DesignPatterns.Repository;
using DesignPatterns.Models.Data;
using DesignPatterns.Tools.Singleton;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace DesignPatterns.AspNetCore.Controllers;

public class HomeController : Controller
{
    private readonly IOptions<AppSettings> _appSettings;
    private readonly Log _logger;
    private readonly IRepository<Product> _productRepository;

    public HomeController(IOptions<AppSettings> appSettings, IRepository<Product> productRepository)
    {
        _appSettings = appSettings;
        _logger = Log.GetInstance(_appSettings.Value.PathLog);
        _productRepository = productRepository;
    }

    public IActionResult Index()
    {
        _logger.Save("Entered Index");
        var products = _productRepository.Get();
        return View("Index", products);
    }

    public IActionResult Privacy()
    {
        _logger.Save("Entered Privacy");
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

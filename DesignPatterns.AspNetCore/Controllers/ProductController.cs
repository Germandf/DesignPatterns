using DesignPatterns.AspNetCore.Models;
using DesignPatterns.AspNetCore.Strategies;
using DesignPatterns.Models.Data;
using DesignPatterns.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DesignPatterns.AspNetCore.Controllers;

public class ProductController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public ProductController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IActionResult Index()
    {
        IEnumerable<ProductViewModel> products = from p in _unitOfWork.Products.Get()
                                                 select new ProductViewModel
                                                 {
                                                     Id = p.Id,
                                                     Name = p.Name,
                                                     Description = p.Description
                                                 };
        return View("Index", products);
    }

    [HttpGet]
    public IActionResult Add()
    {
        var brands = _unitOfWork.Brands.Get();
        ViewBag.Brands = new SelectList(brands, "Id", "Name");
        return View();
    }

    [HttpPost]
    public IActionResult Add(ProductFormViewModel productFormViewModel)
    {
        if (!ModelState.IsValid)
        {
            var brands = _unitOfWork.Brands.Get();
            ViewBag.Brands = new SelectList(brands, "Id", "Name");
            return View("Add", productFormViewModel);
        }

        var context = productFormViewModel.BrandId is null ?
            new ProductContext(new ProductWithNewBrandStrategy()) :
            new ProductContext(new ProductWithExistingBrandStrategy());
        context.Add(productFormViewModel, _unitOfWork);

        return RedirectToAction("Index");
    }
}

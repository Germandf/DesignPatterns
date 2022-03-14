using DesignPatterns.Models.FactoryMethod;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.AspNetCore.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(decimal total)
        {
            // factories
            var localEarnFactory = new LocalEarnFactory(0.20m);
            var foreignEarnFactory = new ForeignEarnFactory(0.30m, 20);

            // products
            var localEarn = localEarnFactory.GetEarn();
            var foreignEarn = foreignEarnFactory.GetEarn();

            // total
            ViewBag.localTotal = total + localEarn.Earn(total);
            ViewBag.foreignTotal = total + foreignEarn.Earn(total);

            return View();
        }
    }
}

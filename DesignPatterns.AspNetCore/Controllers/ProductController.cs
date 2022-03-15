using DesignPatterns.Tools.FactoryMethod;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.AspNetCore.Controllers
{
    public class ProductController : Controller
    {
        private LocalEarnFactory _localEarnFactory;
        private ForeignEarnFactory _foreignEarnFactory;

        public ProductController(LocalEarnFactory localEarnFactory, ForeignEarnFactory foreignEarnFactory)
        {
            // factories by dependency injection
            _localEarnFactory = localEarnFactory;
            _foreignEarnFactory = foreignEarnFactory;
        }

        public IActionResult Index(decimal total)
        {
            // products
            var localEarn = _localEarnFactory.GetEarn();
            var foreignEarn = _foreignEarnFactory.GetEarn();

            // total
            ViewBag.localTotal = total + localEarn.Earn(total);
            ViewBag.foreignTotal = total + foreignEarn.Earn(total);

            return View();
        }
    }
}

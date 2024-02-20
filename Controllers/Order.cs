using Microsoft.AspNetCore.Mvc;

namespace MySecondApp.Controllers
{
    public class Order : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details() 
        {
            return View("details");
        }

        public IActionResult luckyOrder(string luckyOrder)
        {
            ViewBag.luckyOrder = luckyOrder;
            return View();
        }
    }
}

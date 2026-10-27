using AJAXEx.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AJAXEx.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           
            var res = Product.GetProducts();
            return View(res.ToList());
        }


        public IActionResult AJAX()
        {
            return View();
        }
        public IActionResult getProducts()
        {
            var res = Product.GetProducts();
            return Json(res);
        }
    }
}

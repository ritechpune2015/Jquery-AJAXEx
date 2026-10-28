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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromBody]Product rec)
        {
            return Json("Product Saved!");
        }
    }
}

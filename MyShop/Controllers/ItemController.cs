using Microsoft.AspNetCore.Mvc;
using MyShop.Models;

namespace MyShop.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Table()
        {

            var items = new List<Item>();

            return View();
        }
    }
}

using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Assignment1.Controllers
{
    public class HomeController : Controller
    {
        
        private ItemContext _itemContext { get; set; }

        public HomeController(ItemContext ctx) { 
            _itemContext = ctx; 
        }

        [HttpGet]
        public IActionResult Index()
        {
            var items = _itemContext.Items.
                OrderBy(i => i.ProductName).ToList();
            return View(items);
        }

       
    }
}
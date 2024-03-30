using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Edit(int? id)
        {
            Category category = new Category() { CategoryId = id.HasValue?id.Value:0, Description = "This is beverages", Name = "Beverage"};
            return View("Edit", category);
        }
    }
}

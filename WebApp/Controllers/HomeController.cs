using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "this is my new site motherfuckers";
        }

        public string Error()
        {
            return "Houston, we have an error";
        }
    }
}

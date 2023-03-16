using Microsoft.AspNetCore.Mvc;

namespace WebApplication23.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

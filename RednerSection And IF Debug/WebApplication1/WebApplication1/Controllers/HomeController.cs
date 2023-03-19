using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        [ViewData]

        public string Name { get; set; }
        public IActionResult Index()
        {
            Name= "Index";
            return View();
        }
    }
}

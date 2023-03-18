using Microsoft.AspNetCore.Mvc;
using WebApplication26.Models;
using WebApplication26.Respository;
namespace WebApplication26.Controllers
{
    
    
    public class HomeController : Controller
    {
        private readonly Istudent _istudent;

        public HomeController(Istudent istudent)
        {
            _istudent = istudent;
        }



        public IActionResult Index()
        {
            return View(_istudent.getStudent().ToList());
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]

        public IActionResult Create(student s)
        {

            _istudent.addStudent(s);
            return RedirectToAction("Index");

        }

    }
}

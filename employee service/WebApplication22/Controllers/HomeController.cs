using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication22.Models;

namespace WebApplication22.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,studentInfo e)
        {
            _logger = logger;
            _e = e;
        }

        studentInfo _e;



        [Route("/yasir")]
        public IActionResult Index()
        {

         /*   var a = new List<string>{ "Himanshu","Yasir","Rohan" };

            ViewBag.himanshu = a;

            ViewData["himanshu"] = a;*/
           
            

            return View(_e.getStudent());
        }
        [Route("/rohan")]
        public IActionResult Privacy()
        {
            return View();
        }



        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(student s)
        {
            _e.SetStudent(s);

           return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
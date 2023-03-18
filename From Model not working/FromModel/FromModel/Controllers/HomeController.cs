using Microsoft.AspNetCore.Mvc;
using FromModel.Repositories;
using FromModel.Models;

namespace FromModel.Controllers
{
    public class HomeController : Controller
    {

       private readonly IStudent _is;
        public HomeController(IStudent istud)
        {

            _is = istud;
            
        }
        public IActionResult Index()
        {
            return View(_is.getStudent().ToArray());
        }


        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(student s)
        {
            if(ModelState.IsValid)
            {
                
                _is.seeStudent(s);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Details(int id)
        {
            return View(_is.details(id));
        }

        public IActionResult Edit(int id)
        {
            return View(_is.details(id));
        }
        [HttpPost]
        public IActionResult Edit(student s)
        {
            if (ModelState.IsValid)
            {
                _is.Edit(s);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}

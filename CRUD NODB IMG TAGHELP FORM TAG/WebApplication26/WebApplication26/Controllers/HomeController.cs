﻿using Microsoft.AspNetCore.Mvc;
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


        [Route("/yasir")]

        public IActionResult Taghelper()
        {
            return View("~/Views/Home/Taghelper.cshtml");
        }



        public IActionResult Img()
        {
            return View();
        }


        [HttpPost]

        public IActionResult Create(student s)
        {
if(ModelState.IsValid)
            {

                _istudent.addStudent(s);
                return RedirectToAction("Index");
            }
return View();

        }

    }
}

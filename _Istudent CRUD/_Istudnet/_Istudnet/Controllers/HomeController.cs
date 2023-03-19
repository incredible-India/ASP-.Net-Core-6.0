using _Istudnet.Models;
using _Istudnet.Repository;
using Microsoft.AspNetCore.Mvc;

namespace _Istudnet.Controllers
{
    public class HomeController : Controller
    {
        private readonly _student _st;
        public HomeController(_student st)
        {
            _st = st;
        }
        public IActionResult Index(bool isadd=false)
        {

            ViewBag.isadd = isadd;

            return View(_st.GetStudents());
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Student s)
        {
            if(ModelState.IsValid)
            {
              await  _st.AddStudent(s);
                return RedirectToAction("Index", new {isadd = true});
            }else
            {
                return View();
            }

        }


        public IActionResult Details(int id)
        {
            return View(_st.GetStudentById(id));
        }
    
    }
}

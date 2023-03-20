using _Istudnet.Repository;
using _Istudnet.Models;
using Microsoft.AspNetCore.Mvc;

namespace _Istudnet.Controllers
{
    public class HomeController : Controller
    {
        private readonly _student _st;
        private IWebHostEnvironment _WebHostEnvironment;
        public HomeController(_student st,IWebHostEnvironment webHostEnvironment)
        {
            _st = st;
            _WebHostEnvironment = webHostEnvironment;
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
                if (s.simg != null)
                {
                    string folder = "image";
                    folder += Guid.NewGuid().ToString() + s.simg.FileName;
                    string serverfolder = Path.Combine(_WebHostEnvironment.WebRootPath,folder);
                     await  s.simg.CopyToAsync(new FileStream(serverfolder, FileMode.Create));

                }
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

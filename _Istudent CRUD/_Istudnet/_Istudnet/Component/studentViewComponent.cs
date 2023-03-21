using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _Istudnet.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
namespace _Istudnet.Component
{
    public class studentViewComponent :  ViewComponent
    {

        private readonly _student st; //_st lenge to this lagane ki zarurat na

        public studentViewComponent(_student st)
        {
            this.st = st;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var studentsTop=this.st.GetTopStudents();
            return View(studentsTop);
        }

    }
}

using FromModel.Repositories;
using System.Linq;
namespace FromModel.Models
{
    public class studentservice : IStudent
    {

        List<student> students;


        public studentservice()
        {
            students = new List<student>();
        }

        public List<student> getStudent()
        {
           
            return students;
            
            
        }

        public void seeStudent(student s)
        {
          students.Add(s);
        }

        public object details(int Id)
        {
            return students.Where(p => p.Id == Id).FirstOrDefault();
        }

        public void Edit(student s)
        {
            int index = students.FindIndex(s => s.Id == s.Id);
            students[index] = s;


        }

    }
}

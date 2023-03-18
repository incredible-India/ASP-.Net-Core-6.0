using WebApplication26.Respository;
namespace WebApplication26.Models
{
    public class StudentService :  Istudent
    {
        List<student> students= new List<student>();

        public StudentService()
        {
            List<student> students = new List<student>();
        }


        public List<student> getStudent()
        {
            return students;
        }

        public void addStudent(student student)
        {


            students.Add(student);
        }

        public dynamic getStudentById(int Id)
        {
            return students.Where(Id => Id == Id);
        }

    }
}

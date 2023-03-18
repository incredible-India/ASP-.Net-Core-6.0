using WebApplication26.Models;

namespace WebApplication26.Respository
{
    public interface Istudent
    {
        public List<student> getStudent();

        public void addStudent(student student);

        public dynamic getStudentById(int Id);
    }
}

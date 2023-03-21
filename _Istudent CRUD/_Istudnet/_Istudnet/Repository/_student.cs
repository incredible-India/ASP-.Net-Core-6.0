using _Istudnet.Models;

namespace _Istudnet.Repository
{
    public interface _student
    {

        public List<Student> GetStudents();

        public Task<int> AddStudent(Student s);

        public Student GetStudentById(int id);

        public Task<List<Student>> GetTopStudents();
    }
}

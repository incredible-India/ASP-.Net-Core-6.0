using _Istudnet.Data;
using _Istudnet.Models;
using System.Linq;

namespace _Istudnet.Repository
{

    public class studentService : _student
    {

        private readonly studentContext _studentContext;

        public studentService(studentContext studentContext)
        {
            _studentContext = studentContext;
        }

        public async Task<int> AddStudent(Student Model)
        {
            Student newSt = new Student()
            {

                Name = Model.Name,
                Email = Model.Email,
                Description = Model.Description,
            
           };
         
           await _studentContext.Students.AddAsync(newSt);
            await _studentContext.SaveChangesAsync();
            return Model.Id;
           
           
        }

        public List<Student> GetStudents()
        {
            return _studentContext.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            return _studentContext.Students.Where(Id => Id.Id == id).FirstOrDefault();
        }
    }
}

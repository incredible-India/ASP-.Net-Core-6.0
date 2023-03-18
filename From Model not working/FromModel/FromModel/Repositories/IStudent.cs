using FromModel.Models;
namespace FromModel.Repositories

{
    public interface IStudent 
    {

        public List<student> getStudent();
        public void seeStudent(student s);
        public object details(int id);
        public void Edit(student s);

    }
}

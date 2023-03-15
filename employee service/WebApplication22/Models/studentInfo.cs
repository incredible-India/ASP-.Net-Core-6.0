namespace WebApplication22.Models
{
    public class studentInfo
    {



        List<student> st = new List<student>();

        public List<student> getStudent()
        {
            return st ;
        }

        public void SetStudent(student s)
        {
            st.Add(s);
        }
    }
}

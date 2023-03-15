using System.ComponentModel;

namespace WebApplication22.Models
{
    public class student
    {
        [DisplayName("Student Id")]
        
        public int Id { get; set; }

        public string Name { get; set; }
    }
}

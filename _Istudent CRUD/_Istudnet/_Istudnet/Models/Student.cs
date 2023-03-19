using System.ComponentModel.DataAnnotations;

namespace _Istudnet.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace CodeFirstDefaultController.Models
{
    public class student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
    }
}

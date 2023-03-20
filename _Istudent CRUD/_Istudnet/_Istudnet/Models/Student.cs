using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using _Istudnet.Helper;
namespace _Istudnet.Models
{
    public class Student
    {
        [Key]
  
        public int Id { get; set; }
        [mycustomeValidation(text:"Incadea")]
        public string Name { get; set; }
       
        public string Description { get; set; }
        public string Email { get; set; }
        [NotMapped]
        public IFormFile simg { get; set; }

       
    }
}

using System.ComponentModel.DataAnnotations;

namespace WebApplication26.Models
{
    public class student
    {
        [Required(ErrorMessage="Please Filee the")]
        [System.ComponentModel.DisplayName("Id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Filee Address")]
        [System.ComponentModel.DisplayName("Address Student")]
        public  string Address { get; set; }
        [System.ComponentModel.DisplayName("Hello Name")]
        [Required(ErrorMessage = "Please Filee Name")]
        public string Name  { get; set; }
    }
}

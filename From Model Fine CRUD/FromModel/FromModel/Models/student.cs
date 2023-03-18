using Microsoft.AspNetCore.Components.Forms;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FromModel.Models
{
    public class student
    {
        [Required(ErrorMessage="Please Fill the Student Id")]
        [System.ComponentModel.DisplayName("Id Student")]
    
        public int? Id { get; set; }
        [Required(ErrorMessage = "First name is required")]
        [DisplayName("Name Student")]
        [StringLength(14,MinimumLength =3,ErrorMessage ="14 Se bada Aur 3 se Chhota")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Student Address name is required")]
        [DisplayName("Address Student")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Code Postal name is required")]
        [DisplayName("Code Student")]
        public int? Code { get; set; }
    }
}

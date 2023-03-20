using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _Istudnet.Helper
{
    public class mycustomeValidation : ValidationAttribute
    {
        string? _text;
        public mycustomeValidation(string text)
        {
            _text = text;
        }

        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {

         

            
            if (value != null)
            {
                string? Name = value.ToString();
          

                if (Name.Contains(_text))
                {
                    return ValidationResult.Success;
                }
            }

            return new ValidationResult(ErrorMessage ?? "Name does not contain the desired value");
        }

    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiControlStock.Validations
{
    public class ProductoSoloHyS : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }
            var linea = Convert.ToChar(value);

            if (linea == 'H' || linea == 'S') 
            {
                return ValidationResult.Success;

            }
            return new ValidationResult("Debe ser S o H");
        }
    }

}


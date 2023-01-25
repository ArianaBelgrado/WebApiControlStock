using System;
using System.ComponentModel.DataAnnotations;


namespace WebApiControlStock.Validations
{
    public class PrecioMayorCero : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var precio = Convert.ToDouble(value);

                if (precio <= 0)
                {
                    return new ValidationResult("El precio debe ser mayor a 0");
                }
                return ValidationResult.Success;
            }
            return ValidationResult.Success;
        }
    }
}

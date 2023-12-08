﻿using System.ComponentModel.DataAnnotations;

namespace DataAPI.Models.Validations
{
    public class Shirt_EnsureCorrectSizeAttribute: ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var shirt = validationContext.ObjectInstance as Shirt;

            if (shirt != null && !string.IsNullOrWhiteSpace(shirt.Gender))
            {
                if (shirt.Gender.Equals("men", StringComparison.OrdinalIgnoreCase) && shirt.Size < 8)
                {
                    return new ValidationResult("Men's shirt size should be greater or equal to 8");
                }

                else if (shirt.Gender.Equals("women", StringComparison.OrdinalIgnoreCase) && shirt.Size < 6)
                {
                    return new ValidationResult("Women's shirt size should be greater or equal to 6");
                }
                
            }

            return ValidationResult.Success;
        }
    }
}

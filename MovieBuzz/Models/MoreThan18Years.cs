using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieBuzz.Models
{
    public class MoreThan18Years:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if(customer.MembershipTypeId==MembershipType.unknown||
                customer.MembershipTypeId==MembershipType.PayasYougo)
            {
                return ValidationResult.Success;
            }

            if(customer.Birthday==null)
            {
                return new ValidationResult("Birthdate is Required");
            }

            var age = DateTime.Today.Year - customer.Birthday.Value.Year;

            return (age >= 18) ? ValidationResult.Success
                    : new ValidationResult("Age should be greater than 18 years for the given membership type");
        }
    }
}
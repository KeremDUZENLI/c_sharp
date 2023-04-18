using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithMethods
{
    public static class Utility
    {
        public static void Validate(IValidator validator, object entity)
        {
            var result = validator.Validate(entity);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }

    public static class Utility2
    {
        public static void ValidateFirstNameIfEmpty(Customer customer)
        {
            if (String.IsNullOrEmpty(customer.FirstName))
            {
                throw new Exception("Validation failed!");
            }
        }

        public static void ValidateLastNameIfEmpty(Customer customer)
        {
            if (String.IsNullOrEmpty(customer.LastName))
            {
                throw new Exception("Validation failed!");
            }
        }

        public static void ValidateIdNumberIfEmpty(Customer customer)
        {
            if (String.IsNullOrEmpty(customer.IdentityNumber))
            {
                throw new Exception("Validation failed!");
            }
        }

        public static void ValidateFirstNameLenght(Customer customer)
        {
            if (customer.FirstName.Length < 2)
            {
                throw new Exception("Validation failed!");
            }
        }
    }
}

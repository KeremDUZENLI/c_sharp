using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithMethods
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty().WithMessage("Name cant be empty!");
            RuleFor(c => c.LastName).NotEmpty().WithMessage("Lastname cant be empty!");
            RuleFor(c => c.IdentityNumber).NotEmpty().WithMessage("ID cant be empty!");
            RuleFor(c => c.IdentityNumber).Must(BeEven);
        }

        private bool BeEven(string arg)
        {
            return true;
        }
    }
}

using Business.Abstract;
using Business.Utilities;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager
    {
        ICustomerDal _customerDal;
        IPersonService _personService;

        public CustomerManager(ICustomerDal customerDal, IPersonService personService)
        {
            _customerDal = customerDal;
            _personService = personService;
        }

        public void Add(Customer customer)
        {
            Utility.Validate(new CustomerValidator(), customer);

            CheckPersonExists(customer);
            CheckIfCustomerExists(customer);
            _customerDal.Add(customer);
        }

        public void AddByOtherBusiness(Customer customer)
        {
            ValidateFirstNameIfEmpty(customer);
            ValidateLastNameIfEmpty(customer);
            ValidateFirstNameLenght(customer);

            CheckIfCustomerExists(customer);

            _customerDal.Add(customer);
        }

        private void CheckIfCustomerExists(Customer customer)
        {
            if (_customerDal.CustomerExists(customer))
            {
                throw new Exception("Customer already exists!");
            }
        }

        public void CheckPersonExists(Person person)
        {
            if (!_personService.CheckPerson(person))
            {
                throw new Exception("Kişi bilgileri hatalı");
            }
        }

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

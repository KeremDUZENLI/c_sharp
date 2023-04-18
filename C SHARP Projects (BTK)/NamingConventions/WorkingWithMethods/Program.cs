using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            customerManager.Add(new Customer { 
                Id = 1,
                CityId = 5,
                FirstName = "xxx",
                LastName = "XXX",
                IdentityNumber = "1234567890",
            });

            customerManager.AddByOtherBusiness(new Customer
            {
                Id = 1,
                CityId = 5,
                FirstName = "xxx",
                LastName = "XXX",
                IdentityNumber = "1234567890",
            });
        }
    }

    public class CustomerManager
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(Customer customer)
        {
            Utility.Validate(new CustomerValidator(), customer);
            _customerDal.Add(customer);
        }

        public void AddByOtherBusiness(Customer customer)
        {
            Utility2.ValidateFirstNameIfEmpty(customer);
            Utility2.ValidateLastNameIfEmpty(customer);
            Utility2.ValidateFirstNameLenght(customer);

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
    }

    public interface ICustomerDal
    {
        void Add(Customer customer);
        bool CustomerExists(Customer customer);
    }

    public class EfCustomerDal : ICustomerDal
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Added to Ef Database");
        }

        public bool CustomerExists(Customer customer)
        {
            return true;
        }
    }

    public class NhCustomerDal : ICustomerDal
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Added to Nh Database");
        }

        public bool CustomerExists(Customer customer)
        {
            return true;
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public int CityId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
    }
}

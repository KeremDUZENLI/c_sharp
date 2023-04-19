using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeDal : IEmployeeDal
    {
        public List<Employee> GetAll()
        {
            return new List<Employee> {
                new Employee
                {
                    Id = 1,
                    FirstName = "xxx",
                    LastName = "yyy",
                    IdentityNumber = "12345",
                    Salary = 2000,
                    YearOfBirth =  1900
                },
                new Employee
                {
                    Id = 2,
                    FirstName = "zzz",
                    LastName = "ttt",
                    IdentityNumber = "23456",
                    Salary = 2000,
                    YearOfBirth =  1900
                },
            };
        }
    }
}

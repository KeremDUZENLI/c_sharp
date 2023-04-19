using Business.Abstract;
using Business.Concrete;
using DataAccess;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICustomerDal>().To<EfCustomerDal>();

            Bind<IEmployeeDal>().To<EfEmployeeDal>();
            Bind<IEmployeeService>().To<EmployeeManager>();

            Bind<IProductDal>().To<EfProductDal>();
            Bind<IProductService>().To<ProductManager>();
        }
    }
}

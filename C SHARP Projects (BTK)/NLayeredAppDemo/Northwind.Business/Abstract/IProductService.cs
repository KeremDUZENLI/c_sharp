using Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}

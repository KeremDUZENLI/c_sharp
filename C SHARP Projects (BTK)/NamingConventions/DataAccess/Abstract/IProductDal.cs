using Entity;
using System.Collections.Generic;

namespace DataAccess
{
    public interface IProductDal
    {
        List<Product> GetAll();
    }
}
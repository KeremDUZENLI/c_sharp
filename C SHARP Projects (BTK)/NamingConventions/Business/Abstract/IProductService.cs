using Entity;
using System.Collections.Generic;

namespace Business
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
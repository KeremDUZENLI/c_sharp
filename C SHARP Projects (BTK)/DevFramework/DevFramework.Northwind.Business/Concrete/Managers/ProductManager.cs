using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Business.ValidationRules.FluentValidation;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities.Concrete;
using System.Collections.Generic;
using DevFramework.Core.Aspects.Postsharp.TransactionAspects;
using DevFramework.Core.DataAccess;
using DevFramework.Core.Aspects.Postsharp;
using DevFramework.Core.CrossCuttingConcerns.Caching.Microsoft;
using DevFramework.Core.Aspects.Postsharp.CacheAspects;
using System.Data.Entity.Infrastructure.Interception;
using DevFramework.Core.Aspects.Postsharp.LogAspects;
using DevFramework.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using DatabaseLogger = System.Data.Entity.Infrastructure.Interception.DatabaseLogger;
using DevFramework.Core.Aspects.Postsharp.PerformanceAspects;
using DevFramework.Core.Aspects.Postsharp.AuthorizationAspects;
using System.Linq;
using AutoMapper;
using DevFramework.Core.Utilities.Mappings;

namespace DevFramework.Northwind.Business.Concrete.Managers
{
    [LogAspect(typeof(FileLogger))]
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        private readonly IMapper _mapper;

        public ProductManager(IProductDal productDal, IMapper mapper)
        {
            _productDal = productDal;
            _mapper = mapper;
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        [PerformanceCounterAspect(2)]
        [SecuredOperation(Roles="Admin,Editor,Student")]
        public List<Product> GetAll()
        {
            var products = _mapper.Map<List<Product>>(_productDal.GetList());
            return products;
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p=>p.ProductId == id);
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }

        [TransactionScopeAspect]
        public void TransactionalOperation(Product product1, Product product2)
        {
            _productDal.Add(product1);
            _productDal.Update(product2);
        }
    }
}

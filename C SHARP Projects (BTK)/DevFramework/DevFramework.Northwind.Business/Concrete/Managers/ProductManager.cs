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

namespace DevFramework.Northwind.Business.Concrete.Managers
{
    class ProductManager : IProductService
    {
        private IProductDal _productDal;
        private readonly IQueryableRepository<Product> _queryable;

        public ProductManager(IProductDal productDal, IQueryableRepository<Product> queryable)
        {
            _productDal = productDal;
            _queryable = queryable;
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        [LogAspect(typeof(DatabaseLogger))]
        public List<Product> GetAll()
        {
            return _productDal.GetList();
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

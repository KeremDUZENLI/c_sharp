using DevFramework.Northwind.DataAccess
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DevFramework.DataAccess.Tests.NHibernateTests
{
    [TestClass]
    public class NHibernateTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            NhProductDal productDal = new NhProductDal(new SqlServerHelper());

            var result = productDal.GetList();

            Assert.AreEqual(85, result.Count);
        }
    }
}

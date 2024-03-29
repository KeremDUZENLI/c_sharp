﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductDetailService
/// </summary>
public class ProductDetailService : IProductDetailService
{
    IProductService _productService = InstanceFactory.GetInstance<IProductService>()
    public List<Product> GetAll()
    {
        return _productService.GetAll();
    }
}
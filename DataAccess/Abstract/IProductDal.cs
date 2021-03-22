using Core.DataAccess;
using Entitites.Concrete;
using Entitites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{//interface'in operasyonları default public
    public interface IProductDal:IEntityRepository<Product>
    {
        //Product'a özel operasyonları yazarız
        List<ProductDetailDto> GetProductDetails();

    }
}

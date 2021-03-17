using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{//interface'in operasyonları default public
    public interface IProductDal:IEntityRepository<Product>
    {
       


    }
}

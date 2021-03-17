using Entitites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{   //generic constarint
    //class:referans tip
    //new(): newlenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //filtre vermese de çalışır
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        //filtre vermesse çalışmaz
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}

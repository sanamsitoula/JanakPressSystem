﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        // T- Category
        IQueryable<T> GetAll();
      //  <T> GetAll(Func<object, bool> value);
        T GetFirstOrDefault(Expression<Func<T , bool>> filter);
       // IQueryable<T> GetAllThroughParam(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
    }
}

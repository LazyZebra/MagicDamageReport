using System;
using System.Linq;
using System.Linq.Expressions;

namespace MDR.DataAccess
{   
    //Petrov: I will not be implementing IDisposable because I'm working with DbContext
    //which already implements it out of the box
    public interface IRepository<T>
    {
        void Add(T entity);
        void Remove(T entity);
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
    }
}
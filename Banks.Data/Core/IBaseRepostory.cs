using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Banks.Data.Core
{
    public interface IBaseRepostory<T> where T:class
    {
        IQueryable<T> GetAll();
        Task<T> GetById(int id);
        IQueryable<T> FindByPreicate(Expression<Func<T,bool>> predcicate);
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
       
    }
}

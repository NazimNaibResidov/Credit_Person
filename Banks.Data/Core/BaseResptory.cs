using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Banks.Data.Core
{
    public class BaseResptory<T>:IBaseRepostory<T> where T:class
    {
        private readonly DbContext context;
        public BaseResptory(DbContext Context)
        {
            context = Context;
        }

        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
            Save();
        }

        public IQueryable<T> FindByPreicate(Expression<Func<T, bool>> predcicate)
        {
           return context.Set<T>().Where(predcicate);
        }

        public IQueryable<T> GetAll()
        {
           return context.Set<T>().AsQueryable();
        }

        public async Task<T> GetById(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public void Remove(T entity)
        {
            context.Set<T>().Remove(entity);
            Save();
        }

        private void Save()
        {
            try
            {
                context.SaveChanges();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
           
        }

        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
        }


    }
}


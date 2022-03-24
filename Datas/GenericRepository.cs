using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizDemo.Datas
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ApplicationSqlContext context;
        public GenericRepository(ApplicationSqlContext context)
        {
            this.context = context;
        }
        void IGenericRepository<T>.Add(T entity)
        {
            context.Set<T>().Add(entity);
        }

        void IGenericRepository<T>.Delete(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        IEnumerable<T> IGenericRepository<T>.GetAll()
        {
            return context.Set<T>().ToList();
        }

        T IGenericRepository<T>.GetById(long id)
        {
            return context.Set<T>().Find(id);
        }

        void IGenericRepository<T>.Update(T entity)
        {
            context.Set<T>().Update(entity);
        }
    }
}

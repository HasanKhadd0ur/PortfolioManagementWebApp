using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using cleanArchWebApp.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace cleanArchWebApp.Infrastructure.Respository
{
    public class GenericRepository<T> : IGenericRespository<T> where T : class
    {
        private readonly DbContext _context;
        private DbSet<T> _table;
        public GenericRepository(DbContext context)
        {
            _context = context;
            _table   = _context.Set<T>();
        }
        public void Delete(object id)
        {
            T entity = _table.Find(id);
            _table.Remove(entity);
        }

        public  IEnumerable<T> GetAll()
        {
            return _table.ToList();
        }
        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includeProperties) {

            {
                IQueryable<T> queryable =_table;
                foreach (var includeProperty in includeProperties)
                {
                    queryable = queryable.Include(includeProperty);
                }
                return queryable.AsEnumerable();
            }
        }

        public T GetById(object id  ,  Expression<Func<T, object>>[] includeProperties = null)
        {

            IQueryable<T> query = _table;
            if(includeProperties is not null)
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return _table.Find(id);
        }

        public T Insert(T entity)
        {
            return _table.Add(entity).Entity;
        }

        public void Update(T entity)
        {
            _table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;

        }
    }
}

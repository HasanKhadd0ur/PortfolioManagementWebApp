using System;
using System.Collections.Generic;
using System.Linq;
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
        void IGenericRespository<T>.Delete(object id)
        {
            T entity = _table.Find(id);
            _table.Remove(entity);
        }

        IEnumerable<T> IGenericRespository<T>.GetAll()
        {
            return _table.ToList();
        }

        T IGenericRespository<T>.GetById(object id)
        {
            return _table.Find(id);
        }

        T IGenericRespository<T>.Insert(T entity)
        {
            return _table.Add(entity).Entity;
        }

        void  IGenericRespository<T>.Update(T entity)
        {
            _table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;

        }
    }
}

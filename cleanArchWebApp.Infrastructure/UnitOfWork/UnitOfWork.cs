using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using cleanArchWebApp.ApplicationCore.Interfaces;
using cleanArchWebApp.Infrastructure.Respository;
using Microsoft.EntityFrameworkCore;

namespace cleanArchWebApp.Infrastructure.UnitOfWork
{
    class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private readonly DbContext _context;
        private IGenericRespository<T> _entity;
        public UnitOfWork(DbContext context)
        {
            _context = context;

        }

        public IGenericRespository<T> Entity
        {
                get {

                    return _entity ?? (_entity = new GenericRepository<T>(_context));
                }
            
                
                
                
        }

        void IUnitOfWork<T>.Save()
        {
            _context.SaveChanges();
        }
    }
}

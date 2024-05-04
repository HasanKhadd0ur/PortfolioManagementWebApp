using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using cleanArchWebApp.ApplicationCore.Interfaces;
using cleanArchWebApp.Infrastructure.Respository;
using Microsoft.EntityFrameworkCore;
using cleanArchWebApp.Infrastructure;
namespace cleanArchWebApp.Infrastructure.UnitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private readonly DbContext _context;
        private IGenericRespository<T> _entity;
        public UnitOfWork(DbContext context) {
            _context = context;
            _entity = new GenericRepository<T>(context);   
        }

        /*public UnitOfWork()
        {
            
            var contextOptions = new DbContextOptionsBuilder<ProtofoiloDBContext>()
                .UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=portfoilo;Integrated Security=True")
                .Options;
            _context = new ProtofoiloDBContext(contextOptions);
            
        }
    */
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

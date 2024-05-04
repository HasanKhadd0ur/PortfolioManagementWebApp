using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace cleanArchWebApp.ApplicationCore.Interfaces
{
    public  interface IGenericRespository<T> where T :  class    
    {
        public IEnumerable<T> GetAll();
        public void Update(T entities);
        public T Insert(T entities);
        public T GetById(object  id, Expression<Func<T, object>>[] includeProperties = null);
        public void Delete(object id);
        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includeProperties);
        
    }
}

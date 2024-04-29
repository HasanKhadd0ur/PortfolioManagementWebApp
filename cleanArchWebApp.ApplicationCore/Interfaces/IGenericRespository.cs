using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanArchWebApp.ApplicationCore.Interfaces
{
    public  interface IGenericRespository<T> where T : class 
    {
        IEnumerable<T> GetAll();
        void Update(T entities);
        T Insert(T entities);
        T GetById(object  id);
        void Delete(object id);
    }
}

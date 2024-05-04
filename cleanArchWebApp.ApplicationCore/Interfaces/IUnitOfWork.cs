using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanArchWebApp.ApplicationCore.Interfaces
{
    public interface IUnitOfWork<T> where T : class 
    {
        IGenericRespository<T> Entity { get;  }
        void Save(); 

    }
}

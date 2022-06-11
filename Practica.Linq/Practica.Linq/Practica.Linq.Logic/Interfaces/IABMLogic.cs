using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Logic.Interfaces
{
    interface IABMLogic<T, IDType>
    {
        DataTable GetAll();
        DataTable GetByID(IDType id);
        void Add(T entity);
        void Update(T entity);
        void Delete(IDType id);

    }
}

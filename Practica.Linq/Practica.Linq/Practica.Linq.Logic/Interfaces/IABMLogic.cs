using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Logic.Interfaces
{
    interface IABMLogic<T, IDType>
    {
        List<T> GetAll();
        T GetByID(IDType id);
        void Add(T entity);
        void Update(T entity);
        void Delete(IDType id);
    }
}

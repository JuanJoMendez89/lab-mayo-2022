using Practica.EF.Data.Data;
using Practica.EF.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Data.Interfaces
{
    interface ICRUDData<T, IDType>
    {
        List<T> GetAll();
        T GetByID(IDType id);
        void Add(T entity);
        void Update(T entity);
        void Delete(IDType id);
    }
}

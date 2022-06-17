using Practica.EF.Entities.Entities;
using System.Collections.Generic;

namespace Practica.EF.Logic.Interfaces
{
    public interface ICRUDLogic<T, IDType>
    {
        List<T> GetAll();
        T GetByID(IDType id);
        void Add(T entity);
        void Update(T entity);
        void Delete(IDType id);

    }
}

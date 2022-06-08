using Practica.EF.Entities.Entities;
using System.Collections.Generic;

namespace Practica.EF.Logic.Interfaces
{
    public interface IABMLogic<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetByID(string id);
        void Add(T entity);
        void Update(T entity);
        void Delete(string id);

    }
}

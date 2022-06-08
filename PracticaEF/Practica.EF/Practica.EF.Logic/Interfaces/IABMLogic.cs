using Practica.EF.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

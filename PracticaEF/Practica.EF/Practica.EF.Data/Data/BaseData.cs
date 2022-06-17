using Practica.EF.Data.Context;
using Practica.EF.Data.Interfaces;
using Practica.EF.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Data.Data
{
    public abstract class BaseData<T, IDType> : ICRUDData<T, IDType> 
    {
        protected readonly NorthwindContext _context;

        public BaseData()
        {
            _context = new NorthwindContext();
        }

        public abstract void Add(T entity);
        public abstract void Delete(IDType id);
        public abstract List<T> GetAll();
        public abstract T GetByID(IDType id);
        public abstract void Update(T entity);
    }
}

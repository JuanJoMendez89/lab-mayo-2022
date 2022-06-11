using Practica.Linq.Data.Data;
using Practica.Linq.Entities.Entities;
using Practica.Linq.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Logic.Logic
{
    public class SuppliersLogic : IABMLogic<Suppliers, int>
    {
        private readonly SuppliersData _suppliersData;

        public SuppliersLogic()
        {
            _suppliersData = new SuppliersData();
        }

        public void Add(Suppliers entity)
        {
            _suppliersData.Add(entity);
        }

        public void Delete(int id)
        {
            _suppliersData.Delete(id);
        }

        public List<Suppliers> GetAll()
        {
            return _suppliersData.GetAll();
        }

        public Suppliers GetByID(int id)
        {
            return _suppliersData.GetByID(id);
        }

        public void Update(Suppliers entity)
        {
            _suppliersData.Update(entity);
        }
    }
}

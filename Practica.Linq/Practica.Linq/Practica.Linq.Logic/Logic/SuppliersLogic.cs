using Practica.Linq.Data.Data;
using Practica.Linq.Entities.Entities;
using Practica.Linq.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Logic.Logic
{
    public class SuppliersLogic : BaseLogic<Suppliers>, IABMLogic<Suppliers, int>
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

        public DataTable GetAll()
        {
            return ConvertirListaATabla(_suppliersData.GetAll());
        }

        public DataTable GetByID(int id)
        {
            return ConvertirEntidadATabla(_suppliersData.GetByID(id));
        }

        public void Update(Suppliers entity)
        {
            _suppliersData.Update(entity);
        }
    }
}

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
    public class SuppliersLogic : BaseLogic<Suppliers, int>
    {
        private readonly SuppliersData _suppliersData;

        public SuppliersLogic()
        {
            _suppliersData = new SuppliersData();
        }

        public override void Add(Suppliers entity)
        {
            _suppliersData.Add(entity);
        }

        public override void Delete(int id)
        {
            _suppliersData.Delete(id);
        }

        public override DataTable GetAll()
        {
            return ConvertirListaATabla(_suppliersData.GetAll());
        }

        public override DataTable GetByID(int id)
        {
            return ConvertirEntidadATabla(_suppliersData.GetByID(id));
        }

        public override void Update(Suppliers entity)
        {
            _suppliersData.Update(entity);
        }
    }
}

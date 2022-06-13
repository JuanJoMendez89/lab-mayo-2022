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
    public class ShippersLogic : BaseLogic<Shippers, int>
    {
        private readonly ShippersData _shippersData;

        public ShippersLogic()
        {
            _shippersData = new ShippersData();
        }

        public override void Add(Shippers entity)
        {
            _shippersData.Add(entity);
        }

        public override void Delete(int id)
        {
            _shippersData.Delete(id);
        }

        public override DataTable GetAll()
        {
            return ConvertirListaATabla(_shippersData.GetAll());
        }

        public override DataTable GetByID(int id)
        {
            return ConvertirEntidadATabla(_shippersData.GetByID(id));
        }

        public override void Update(Shippers entity)
        {
            _shippersData.Update(entity);
        }
    }
}

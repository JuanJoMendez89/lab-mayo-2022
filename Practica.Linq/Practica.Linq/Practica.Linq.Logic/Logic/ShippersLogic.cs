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
    public class ShippersLogic : BaseLogic<Shippers>, IABMLogic<Shippers, int>
    {
        private readonly ShippersData _shippersData;

        public ShippersLogic()
        {
            _shippersData = new ShippersData();
        }

        public void Add(Shippers entity)
        {
            _shippersData.Add(entity);
        }

        public void Delete(int id)
        {
            _shippersData.Delete(id);
        }

        public DataTable GetAll()
        {
            return ConvertirListaATabla(_shippersData.GetAll());
        }

        public DataTable GetByID(int id)
        {
            return ConvertirEntidadATabla(_shippersData.GetByID(id));
        }

        public void Update(Shippers entity)
        {
            _shippersData.Update(entity);
        }
    }
}

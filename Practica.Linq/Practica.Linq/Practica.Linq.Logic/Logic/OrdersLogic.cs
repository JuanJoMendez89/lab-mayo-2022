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
    public class OrdersLogic : BaseLogic<Orders, int>
    {
        private readonly OrdersData _ordersData;

        public OrdersLogic()
        {
            _ordersData = new OrdersData();
        }

        public override void Add(Orders entity)
        {
            _ordersData.Add(entity);
        }

        public override void Delete(int id)
        {
            _ordersData.Delete(id);
        }

        public override DataTable GetAll()
        {
            return ConvertirListaATabla(_ordersData.GetAll());
        }

        public override DataTable GetByID(int id)
        {
            return ConvertirEntidadATabla(_ordersData.GetByID(id));
        }

        public override void Update(Orders entity)
        {
             _ordersData.Update(entity);
        }
    }
}

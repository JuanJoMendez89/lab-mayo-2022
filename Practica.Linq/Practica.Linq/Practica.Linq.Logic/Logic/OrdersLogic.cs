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
    public class OrdersLogic : IABMLogic<Orders, int>
    {
        private readonly OrdersData _ordersData;

        public OrdersLogic()
        {
            _ordersData = new OrdersData();
        }

        public void Add(Orders entity)
        {
            _ordersData.Add(entity);
        }

        public void Delete(int id)
        {
            _ordersData.Delete(id);
        }

        public List<Orders> GetAll()
        {
            return _ordersData.GetAll();
        }

        public Orders GetByID(int id)
        {
            return _ordersData.GetByID(id);
        }

        public void Update(Orders entity)
        {
             _ordersData.Update(entity);
        }
    }
}

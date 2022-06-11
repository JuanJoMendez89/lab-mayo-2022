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
    public class Order_DetailsLogic : IABMLogic<Order_Details, int>
    {
        private readonly Order_DetailsData _order_DetailsData;

        public Order_DetailsLogic()
        {
            _order_DetailsData = new Order_DetailsData();
        }
        public void Add(Order_Details entity)
        {
            _order_DetailsData.Add(entity);
        }

        public void Delete(int id)
        {
            _order_DetailsData.Delete(id);
        }

        public List<Order_Details> GetAll()
        {
            return _order_DetailsData.GetAll();
        }

        public Order_Details GetByID(int id)
        {
            return _order_DetailsData.GetByID(id);
        }

        public void Update(Order_Details entity)
        {
            _order_DetailsData.Update(entity);
        }
    }
}

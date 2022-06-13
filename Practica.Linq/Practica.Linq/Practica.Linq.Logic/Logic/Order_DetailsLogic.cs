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
    public class Order_DetailsLogic : BaseLogic<Order_Details, int>
    {
        private readonly Order_DetailsData _order_DetailsData;

        public Order_DetailsLogic()
        {
            _order_DetailsData = new Order_DetailsData();
        }
        public override void Add(Order_Details entity)
        {
            _order_DetailsData.Add(entity);
        }

        public override void Delete(int id)
        {
            _order_DetailsData.Delete(id);
        }

        public override DataTable GetAll()
        {
            return ConvertirListaATabla(_order_DetailsData.GetAll());
        }

        public override DataTable GetByID(int id)
        {
            return ConvertirEntidadATabla(_order_DetailsData.GetByID(id));
        }

        public override void Update(Order_Details entity)
        {
            _order_DetailsData.Update(entity);
        }
    }
}

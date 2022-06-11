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
    public class CustomersLogic : BaseLogic<Customers>, IABMLogic<Customers, string>
    {
        private readonly CustomersData _customersData;

        public CustomersLogic()
        {
            _customersData = new CustomersData();
        }

        public void Add(Customers entity)
        {
            _customersData.Add(entity);
        }

        public void Delete(string id)
        {
            _customersData.Delete(id);
        }

        public DataTable GetAll()
        {
            return ConvertirListaATabla(_customersData.GetAll());
        }

        public DataTable GetByID(string id)
        {
            DataTable customer = ConvertirEntidadATabla(_customersData.GetByID(id));
            customer.Columns.Remove("Orders");
            customer.Columns.Remove("CustomerDemographics");

            return customer;
        }

        public void Update(Customers entity)
        {
            _customersData.Update(entity);
        }
    }
}

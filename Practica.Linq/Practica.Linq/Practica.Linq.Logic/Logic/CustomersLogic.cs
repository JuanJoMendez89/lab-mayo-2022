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
    public class CustomersLogic : IABMLogic<Customers, string>
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

        public List<Customers> GetAll()
        {
            return _customersData.GetAll();
        }

        public Customers GetByID(string id)
        {
            return _customersData.GetByID(id);
        }

        public void Update(Customers entity)
        {
            _customersData.Update(entity);
        }
    }
}

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
    public class CustomerDemographicsLogic : BaseLogic<CustomerDemographics>, IABMLogic<CustomerDemographics, string>
    {
        private readonly CustomerDemographicsData _customerDemographics;

        public CustomerDemographicsLogic()
        {
            _customerDemographics = new CustomerDemographicsData();
        }

        public void Add(CustomerDemographics entity)
        {
            _customerDemographics.Add(entity);
        }

        public void Delete(string id)
        {
            _customerDemographics.Delete(id);
        }

        public DataTable GetAll()
        {
            return ConvertirListaATabla(_customerDemographics.GetAll());
        }

        public DataTable GetByID(string id)
        {
            return ConvertirEntidadATabla(_customerDemographics.GetByID(id));
        }

        public void Update(CustomerDemographics entity)
        {
            _customerDemographics.Update(entity);
        }
    }
}

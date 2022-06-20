using Practica.EF.Entities.Models;
using Practica.EF.Logic.Logic;
using Practica.EF.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Service.Services
{
    public class CustomersService : ICustomersService
    {
        private CustomersLogic _customersLogic;

        public CustomersService(CustomersLogic customersLogic)
        {
            _customersLogic = customersLogic;
        }

        public void Add(CustomersDTO customersDTO)
        {
            _customersLogic.Add(customersDTO);
        }

        public void Delete(string id)
        {
            _customersLogic.Delete(id);
        }

        public List<CustomersDTO> GetAll()
        {
            return _customersLogic.GetAll();
        }

        public CustomersDTO GetByID(string id)
        {
            return _customersLogic.GetByID(id);
        }

        public void Update(CustomersDTO customersDTO)
        {
            _customersLogic.Update(customersDTO);
        }
    }
}

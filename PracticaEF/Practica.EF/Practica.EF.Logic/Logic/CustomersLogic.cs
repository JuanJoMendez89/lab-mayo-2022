using Practica.EF.Common.Exceptions;
using Practica.EF.Data.Data;
using Practica.EF.Entities.Entities;
using Practica.EF.Entities.Models;
using Practica.EF.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

using Practica.EF.Logic.Extensions;

namespace Practica.EF.Logic.Logic
{
    public class CustomersLogic : BaseLogic, ICRUDLogic<CustomersDTO, string>
    {
        private CustomersData _customersData;

        public CustomersLogic()
        {
            _customersData = new CustomersData();
        }

        public void Add(CustomersDTO entity)
        {
            try
            {
                _customersData.Add(entity.MapToCustomers());
            }
            catch (Exception ex)
            {
                throw ex.GetBaseException();
            }

        }

        public void Delete(string id)
        {
            try
            {
                _customersData.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex.GetBaseException();
            }
        }

        public List<CustomersDTO> GetAll()
        {
            try
            {
                List<Customers> customers = _customersData.GetAll();

                return customers.Select(c => c.CreateDTO()).ToList();
            }
            catch (Exception ex)
            {
                throw ex.GetBaseException();
            }

        }

        public CustomersDTO GetByID(string id)
        {
            return _customersData.GetByID(id).CreateDTO();
        }

        public void Update(CustomersDTO entity)
        {
            try
            {
                _customersData.Update(entity.MapToCustomers());
            }
            catch (Exception ex)
            {
                throw ex.GetBaseException();
            }

        }
    }
}

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

        public void Add(CustomersDTO customersDTO)
        {
            try
            {
                Customers customer = customersDTO.ReverseMap();
                customer.CustomerID = customer.CustomerID.TrimEnd();

                ValidateCustomer(customer);

                _customersData.Add(customer);
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
            Customers customer = _customersData.GetByID(id);

            if (customer == null)
                throw new KeyNotFoundException("Customer not found");

            return customer.CreateDTO();
        }

        public void Update(CustomersDTO customersDTO)
        {
            try
            {
                Customers customer = customersDTO.ReverseMap();

                ValidateCustomer(customer);

                _customersData.Update(customer);
            }
            catch (Exception ex)
            {
                throw ex.GetBaseException();
            }

        }

        private void ValidateCustomer(Customers customer) {
            if (String.IsNullOrEmpty(customer.CustomerID) || String.IsNullOrWhiteSpace(customer.CustomerID))
                throw new InvalidFieldException("Field value is empty or invalid", "CustomerID");

            if (customer.CustomerID.Length != 5)
                throw new InvalidFieldException("CustomerID length value must be 5", "CustomerID");

            if (String.IsNullOrEmpty(customer.ContactName) || String.IsNullOrWhiteSpace(customer.ContactName))
                throw new InvalidFieldException("Field value is empty or invalid", "ContactName");

            if (String.IsNullOrEmpty(customer.CompanyName) || String.IsNullOrWhiteSpace(customer.CompanyName)) 
                throw new InvalidFieldException("Field value is empty or invalid", "CompanyName");
        }

    }
}

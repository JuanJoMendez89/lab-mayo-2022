using Practica.EF.Entities.Entities;
using Practica.EF.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic.Mappers
{
    public class CustomersMapper
    {
        public CustomersDTO CreateCustomersDTO(Customers customer) {
            return new CustomersDTO
            {
                CustomerID = customer.CustomerID,
                CompanyName = customer.CompanyName,
                ContactName = customer.ContactName,
                ContactTitle = customer.ContactTitle,
                Address = customer.Address,
                City = customer.City,
                Region = customer.Region,
                PostalCode = customer.PostalCode,
                Country = customer.Country,
                Phone = customer.Phone,
                Fax = customer.Fax
            };
        }

        public Customers CustomersDTOToCustomers(CustomersDTO customerDTO)
        {
            return new Customers
            {
                CustomerID = customerDTO.CustomerID,
                CompanyName = customerDTO.CompanyName,
                ContactName = customerDTO.ContactName,
                ContactTitle = customerDTO.ContactTitle,
                Address = customerDTO.Address,
                City = customerDTO.City,
                Region = customerDTO.Region,
                PostalCode = customerDTO.PostalCode,
                Country = customerDTO.Country,
                Phone = customerDTO.Phone,
                Fax = customerDTO.Fax
            };
        }

    }
}

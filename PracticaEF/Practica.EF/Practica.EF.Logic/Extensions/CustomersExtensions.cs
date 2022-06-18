using Practica.EF.Entities.Entities;
using Practica.EF.Entities.Models;
using Practica.EF.Logic.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic.Extensions
{
    public static class CustomersExtensions
    {
        public static CustomersDTO CreateDTO(this Customers customers) {
            return new CustomersMapper().CreateCustomersDTO(customers);
        }

        public static Customers MapCustomersDto(this Customers customer, CustomersDTO customerDTO) {
            return new CustomersMapper().CustomersDTOToCustomers(customerDTO);
        }

    }
}

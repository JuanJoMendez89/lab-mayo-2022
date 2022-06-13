﻿using Practica.Linq.Data.Data;
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
    public class CustomersLogic : BaseLogic<Customers, string>
    {
        private readonly CustomersData _customersData;

        public CustomersLogic()
        {
            _customersData = new CustomersData();
        }

        public override void Add(Customers entity)
        {
            _customersData.Add(entity);
        }

        public override void Delete(string id)
        {
            _customersData.Delete(id);
        }

        public override DataTable GetAll()
        {
            return ConvertirListaATabla(_customersData.GetAll());
        }

        public override DataTable GetByID(string id)
        {
            try
            {
                DataTable tbCustomer = new DataTable();
                Customers customer = _customersData.GetByID(id);

                if (customer != null)
                {
                    tbCustomer = ConvertirEntidadATabla(_customersData.GetByID(id));
                    tbCustomer.Columns.Remove("Orders");
                    tbCustomer.Columns.Remove("CustomerDemographics");
                }
                else {
                    tbCustomer.Columns.Add(" ");
                    tbCustomer.Rows.Add("Sin resultados.");
                }

                return tbCustomer;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Update(Customers entity)
        {
            _customersData.Update(entity);
        }

        public DataTable GetByRegionWa() {
            DataTable tbCustomers = new DataTable();
            List<Customers> customers = _customersData.GetByRegionWa();

            if (customers.Count > 0)
            {
                tbCustomers = ConvertirListaATabla(customers);
                tbCustomers.Columns.Remove("Orders");
                tbCustomers.Columns.Remove("CustomerDemographics");
            }
            else
            {
                tbCustomers.Columns.Add(" ");
                tbCustomers.Rows.Add("Sin resultados.");
            }
            return tbCustomers;
        }

        public DataTable GetNombres()
        {
            return ConvertirListaATabla(_customersData.GetNombres());
        }

        public DataTable GetCustomerByFechaOrder()
        {
            DataTable tbCustomer = ConvertirListaATabla(_customersData.GetCustomerByFechaOrder());

            foreach (DataRow row in tbCustomer.Rows) {
                row["OrderDate"] = Convert.ToDateTime(row["OrderDate"]).ToString("dd/MM/yyyy");
            }

            return tbCustomer;
        }

        public DataTable GetByPrimerosRegionWa()
        {
            DataTable tbCustomers = new DataTable();
            List<Customers> customers = _customersData.GetByPrimerosRegionWa();

            if (customers.Count > 0)
            {
                tbCustomers = ConvertirListaATabla(customers);
                tbCustomers.Columns.Remove("Orders");
                tbCustomers.Columns.Remove("CustomerDemographics");
            }
            else
            {
                tbCustomers.Columns.Add(" ");
                tbCustomers.Rows.Add("Sin resultados.");
            }
            return tbCustomers;
        }

        public DataTable GetCustomerConOrdenesAsociadas() {
            return ConvertirListaATabla(_customersData.GetCustomerConOrdenesAsociadas());
        }
    }
}

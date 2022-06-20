using Practica.EF.Entities.Models;
using Practica.EF.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Practica.EF.Web.Api.Controllers
{
    public class CustomersController : ApiController
    {
        private ICustomersService _customersService;

        public CustomersController(ICustomersService customersService)
        {
            _customersService = customersService;
        }

        // GET api/<controller>
        public IHttpActionResult Get()
        {
            try
            {
                List<CustomersDTO> shippers = _customersService.GetAll();
                return Ok(shippers);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<controller>/5
        public IHttpActionResult GetShipper(string id)
        {
            try
            {
                CustomersDTO shipper = _customersService.GetByID(id);

                return Ok(shipper);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody] CustomersDTO customer)
        {
            try
            {
                if (customer.CustomerID == null)
                    return BadRequest("CustomerID is empty or invalid");

                _customersService.Add(customer);

                return Ok("Customer created successfully!!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(string id, [FromBody] CustomerEdit customer)
        {
            try
            {
                CustomersDTO customerDTO = new CustomersDTO
                {
                    CustomerID = id,
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


                _customersService.Update(customerDTO);

                return Ok("Customer updated successfully!!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(string id)
        {
            try
            {
                _customersService.Delete(id);

                return Ok("Customer deleted successfully!!");
            }
            catch (Exception ex)
            {
                if (ex.GetType() == typeof(ArgumentNullException))
                {
                    return BadRequest("Customer not found");

                }
                else if (ex.GetType() == typeof(SqlException))
                {
                    return BadRequest("Can't delete. There're orders bound this Customer.");

                }
                else
                {
                    return BadRequest(ex.Message);
                }

            }
        }
    }
}
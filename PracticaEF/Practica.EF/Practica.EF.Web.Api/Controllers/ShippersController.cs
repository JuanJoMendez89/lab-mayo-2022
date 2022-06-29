using Practica.EF.Entities.Models;
using Practica.EF.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Practica.EF.Web.Api.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class ShippersController : ApiController
    {
        private IShippersService _shippersService;

        public ShippersController(IShippersService shippersService)
        {
            _shippersService = shippersService;
        }

        // GET api/<controller>
        public IHttpActionResult Get()
        {
            try
            {
                List<ShippersDTO> shippers = _shippersService.GetAll();
                return Ok(shippers);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<controller>/5
        public IHttpActionResult GetShipper(int id)
        {
            try
            {
                ShippersDTO shipper = _shippersService.GetByID(id);

                return Ok(shipper);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody] ShippersRequest shipper)
        {
            try
            {
                ShippersDTO shipperDTO = new ShippersDTO
                {
                    CompanyName = shipper.CompanyName,
                    Phone = shipper.Phone
                };

                _shippersService.Add(shipperDTO);

                return Ok("Shipper created successfully!!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody] ShippersRequest shipper)
        {
            try
            {
                ShippersDTO shipperDTO = new ShippersDTO
                {
                    ShipperID = id,
                    CompanyName = shipper.CompanyName,
                    Phone = shipper.Phone
                };


                _shippersService.Update(shipperDTO);

                return Ok("Shipper updated successfully!!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                _shippersService.Delete(id);

                return Ok("Shipper deleted successfully!!");
            }
            catch (Exception ex)
            {
                if (ex.GetType() == typeof(ArgumentNullException))
                {
                    return BadRequest("Shipper not found");

                } else if (ex.GetType() == typeof(SqlException)) {
                    return BadRequest("Can't delete. There're orders bound this shipper.");

                }
                else {
                    return BadRequest(ex.Message);
                }

            }
        }
    }
}
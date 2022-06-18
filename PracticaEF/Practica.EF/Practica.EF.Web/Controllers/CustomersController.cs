using Practica.EF.Entities.Models;
using Practica.EF.Logic.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Practica.EF.Web.Controllers
{
    public class CustomersController : Controller
    {
        CustomersLogic customerLogic = new CustomersLogic();

        // GET: Customers
        public ActionResult Index()
        {
            List<CustomersDTO> customers = customerLogic.GetAll();

            return View("CustomersList", customers);
        }

        [HttpPost]
        public ActionResult Create(CustomersDTO customer)
        {
            try
            {
                customerLogic.Add(customer);

                return Json(new { status = "ok", message = "Customer created." }, JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json(new { status = "error", message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }


        // PUT: Customers
        [HttpPut]
        public ActionResult Update(CustomersDTO customer)
        {
            try
            {
                customerLogic.Update(customer);
                
                return Json(new { status = "ok", message = "Customer updated." }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json(new { status = "error", message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpDelete]
        public ActionResult Delete(string id)
        {
            try
            {
                customerLogic.Delete(id);

                return Json(new { status = "ok", message = "Customer deleted." }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json(new { status = "error", message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

    }
}

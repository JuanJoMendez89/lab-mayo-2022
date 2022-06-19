using Practica.EF.Entities.Models;
using Practica.EF.Logic.Logic;
using Practica.EF.Web.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Practica.EF.Web.Controllers
{
    public class ShippersController : Controller
    {
        ShippersLogic shippersLogic = new ShippersLogic();

        // GET: Shippers
        public ActionResult Index()
        {
            return View("ShippersList", shippersLogic.GetAll());
        }

        [HttpPost]
        public ActionResult Create(ShippersDTO shipper)
        {
            try
            {
                shippersLogic.Add(shipper);

                return Json(new { status = "ok", message = "Customer created." }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json(new { status = "error", message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPut]
        public ActionResult Update(ShippersDTO shipper)
        {
            try
            {
                shippersLogic.Update(shipper);

                return Json(new { status = "ok", message = "Customer updated." }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json(new { status = "error", message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult DeleteConfirmation(int id)
        {
            return View("Delete", shippersLogic.GetByID(id));

        }

        public ActionResult Delete(int id)
        {
            try
            {
                shippersLogic.Delete(id);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                if (ex.GetType().Name == "SqlException") {
                    return RedirectToAction("Error", "Shippers", new { error = "Can't delete. There're orders bound this shipper." });
                }
                else
                { 
                  return RedirectToAction("Error", "Shippers", new { error = ex.Message });
                }
            }
        }

        public ActionResult Error(string error) {
            ErrorViewModel errorViewModel = new ErrorViewModel();
            errorViewModel.ErrorMessage = error;

            return View(errorViewModel);
        }
    }
}

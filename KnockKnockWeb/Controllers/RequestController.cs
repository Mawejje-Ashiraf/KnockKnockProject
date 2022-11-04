using KnockKnockWeb.DataAccess.Contract;
using KnockKnockWeb.DataAccess.Implementation;
using KnockKnockWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KnockKnockWeb.Controllers
{
    public class RequestController : Controller
    {
        IRequestManager requestManager;
        public RequestController(){
            requestManager = new RequestManager();
        }

        [HttpPost]
        public ActionResult AddRequest()
        {   
            RequestModel RequestDetails = new RequestModel();
            RequestDetails.CreatedAt = DateTime.Now;
            RequestDetails.Status = 0;
            bool result = requestManager.AddRequest(RequestDetails); 
            RequestDetails.Requests = requestManager.GetAllRequests();
            ViewBag.Message = (result) ? "Request added Successfully Waiting for Approval" : "Failed to add Request Please try again";
            return View("~/Views/Request/AddViewRequest.cshtml", RequestDetails); 
        }
              
        public ActionResult AddViewRequest()
        {
            RequestModel RequestList = new RequestModel();
            RequestList.Requests = requestManager.GetAllRequests();
            return View(RequestList);
        }

        // POST: Request/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Request/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Request/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Request/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Request/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

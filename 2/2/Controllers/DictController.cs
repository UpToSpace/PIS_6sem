using _2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;

namespace _2.Controllers
{
    [HandleError]
    public class DictController : Controller
    {
        Models.HW_DB db= new Models.HW_DB();

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.getAll = db.GetAll();
            return View();
        }

        [HttpGet]
        public ActionResult Add() 
        { 
            return View();
        }

        [HttpPost]
        public ActionResult AddSave(Data data)
        {
            if (db.Insert(data))
            {
                ViewBag.message = "Insert success";
            }
            else
            {
                ViewBag.message = "Insert failed";
            }
            ViewBag.getAll = db.GetAll();
            return View("Index");
        }

        [HttpGet]
        public ActionResult Update()
        {
            int id = Convert.ToInt32(Url.RequestContext.RouteData.Values["id"]);
            ViewBag.Find = db.Find(id);
            return View();
        }

        [HttpPost]
        public ActionResult UpdateSave(Data data)
        {
            if (db.Update(data))
            {
                ViewBag.message = "Updata success";
            }
            else
            {
                ViewBag.message = "Update failed";
            }
            ViewBag.getAll = db.GetAll();
            return View("Index");
        }

        [HttpGet]
        public ActionResult Delete()
        {
            int id = Convert.ToInt32(Url.RequestContext.RouteData.Values["id"]);
            ViewBag.Find = db.Find(id);
            return View();
        }

        [HttpPost]
        public ActionResult DeleteSave(Data data)
        {
            if (db.Delete(data))
            {
                ViewBag.message = "Delete success";
            }
            else
            {
                ViewBag.message = "Delete failed";
            }

            ViewBag.getAll = db.GetAll();

            return View("Index");
        }
        public ActionResult NotFound()
        {
            Response.StatusCode = 404;
            return View();
        }
    }
}
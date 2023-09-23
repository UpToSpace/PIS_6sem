using _4.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;

namespace _4.Controllers
{
    [HandleError]
    public class DictController : Controller
    {
        Repository db = new Repository();

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.getAll = db.GetDirectoryList();
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
            db.Create(data);

            if (!db.Save()) return new HttpStatusCodeResult(400);
            return Redirect("/Dict/Index");
        }

        [HttpGet]
        public ActionResult Update(Data data)
        {
            int id = Convert.ToInt32(Url.RequestContext.RouteData.Values["id"]);
            ViewBag.Find = db.Find(id);
            return View();
        }

        [HttpPost]
        public ActionResult UpdateSave(Data data)
        {
            db.Update(data);
            if (!db.Save()) return new HttpStatusCodeResult(400);
            return Redirect("/Dict/Index");
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
            db.Delete(data);
            if (!db.Save()) return new HttpStatusCodeResult(400);
            return Redirect("/Dict/Index");
        }

        public ActionResult NotFound()
        {
            Response.StatusCode = 404;
            return View();
        }
    }
}
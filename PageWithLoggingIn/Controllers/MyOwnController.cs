using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PageWithLoggingIn.BusinesLogic;

namespace PageWithLoggingIn.Controllers
{
    
    public class MyOwnController : Controller
    {
        private readonly MyOwnLogic _myOwnLogic;

        public MyOwnController()
        {
            _myOwnLogic = new MyOwnLogic();
        }

        // GET: MyOwn
       
        public ActionResult Index()
        {
            if (_myOwnLogic.CheckIfUserIsLogged())
            {
                return View("~/Views/MyOwn/AuthorizedUser.cshtml");
            }
            return View("~/Views/MyOwn/UnAuthorizedUser.cshtml");
        }

        // GET: MyOwn/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MyOwn/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MyOwn/Create
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

        // GET: MyOwn/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MyOwn/Edit/5
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

        // GET: MyOwn/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MyOwn/Delete/5
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

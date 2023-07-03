using Microsoft.AspNet.Identity;
using MyToDoList.Data;
using MyToDoList.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace MyToDoList.Controllers
{
    [Authorize]
    public class GroceriesController : Controller
    {
        private IGroceriesService _groceries;
        public GroceriesController(IGroceriesService roomTypes)
        {
            _groceries = roomTypes;
        }
        // GET: RoomTypes
        public ActionResult Index()
        {
            return View(_groceries.GetGroceries());
        }
        public ActionResult AddNew()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNew(Groceries model)
        {
            if (ModelState.IsValid)
            {
                var username = User.Identity.GetUserName();
                if (_groceries.Insert(model, username))
                {                  
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
        [EncryptedActionParameter]
        public ActionResult Edit(string id)
        {
            if (!String.IsNullOrEmpty(id))
            {
                try
                {
                    return View(_groceries.GetGroceries(Convert.ToInt32(id)));
                }
                catch { }
            }
            return RedirectToAction("NotFound", "Error");
        }
        [HttpPost]
        public ActionResult Edit(Groceries model)
        {
            if (ModelState.IsValid)
            {
                var username = User.Identity.GetUserName();
                if (_groceries.Update(model, username))
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        [EncryptedActionParameter]
        public ActionResult Delete(string id)
        {
            var username = User.Identity.GetUserName();
            if (!String.IsNullOrEmpty(id))
                _groceries.Delete(_groceries.GetGroceries(Convert.ToInt32(id)));
            return RedirectToAction("Index");
        }

        [EncryptedActionParameter]
        public ActionResult Details(string id)
        {
            if (!String.IsNullOrEmpty(id))
            {
                try
                {
                    return View(_groceries.GetGroceries().Find(p => p.GroceriesId == Convert.ToInt64(id)));
                }
                catch { }
            }
            return RedirectToAction("NotFound", "Error");
        }
    }
}
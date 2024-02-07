using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class ContactController : Controller
    {
        DbMyPortfolioEntities5 db = new DbMyPortfolioEntities5();

        public ActionResult Index()
        {
            var values = db.TblContact.ToList();
            return View(values);
        }

        public ActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateContact(TblContact o)
        {
            db.TblContact.Add(o);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteContact(int id)
        {
            var value = db.TblContact.Find(id);
            db.TblContact.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult UpdateContact(int id)
        {
            var value = db.TblContact.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateContact(TblContact o)
        {
            var value = db.TblContact.Find(o.ContactID);
            value.NameSurname = o.NameSurname;
            value.Message = o.Message;
            value.Email = o.Email;
            value.SendDate = o.SendDate;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

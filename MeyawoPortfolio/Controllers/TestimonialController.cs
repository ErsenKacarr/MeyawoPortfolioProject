using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class TestimonialController : Controller
    {
        DbMyPortfolioEntities5 db = new DbMyPortfolioEntities5();
        public ActionResult Index()
        {
            var values = db.TblTestimonial.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTestimonial(TblTestimonial t)
        {
            db.TblTestimonial.Add(t);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteTestimonial(int id)
        {
            var value = db.TblTestimonial.Find(id);
            db.TblTestimonial.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var value = db.TblTestimonial.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateTestimonial(TblTestimonial t)
        {
            var value = db.TblTestimonial.Find(t.TestimonialID);
            value.NameSurname = t.NameSurname;
            value.Description = t.Description;
            value.Status = t.Status;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
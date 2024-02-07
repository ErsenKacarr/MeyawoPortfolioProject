using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class EducationController : Controller
    {
        DbMyPortfolioEntities5 db = new DbMyPortfolioEntities5();
        public ActionResult Index()
        {
            var values = db.TblEducation.ToList();
            return View(values);
        }

        public ActionResult CreateEducation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateEducation(TblEducation e)
        {
            db.TblEducation.Add(e);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteEducation(int id)
        {
            var value = db.TblEducation.Find(id);
            db.TblEducation.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            var value = db.TblEducation.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateEducation(TblEducation e)
        {
            var value = db.TblEducation.Find(e.EgıtımID);
            value.IlkOkul = e.IlkOkul;
            value.Lise = e.Lise;
            value.Universite = e.Universite;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
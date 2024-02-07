using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class CategoryController : Controller
    {
        DbMyPortfolioEntities5 db = new DbMyPortfolioEntities5();
        public ActionResult Index()
        {
            var values = db.TblCategory.ToList();
            return View(values);
        }


        public ActionResult Index2()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(TblCategory c)
        {
            db.TblCategory.Add(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCategory(int id)
        {
            var value = db.TblCategory.Find(id);
            db.TblCategory.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var value = db.TblCategory.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateCategory(TblCategory c)
        {
            var value = db.TblCategory.Find(c.CategoryID);
            value.CategoryName = c.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class AboutController : Controller
    {
        DbMyPortfolioEntities5 db = new DbMyPortfolioEntities5();
        public ActionResult Index()
        {
            var values = db.TblAbout.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAbout(TblAbout a)
        {
            db.TblAbout.Add(a);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteAbout(int id)
        {
            var value = db.TblAbout.Find(id);
            db.TblAbout.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var value = db.TblAbout.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateAbout(TblAbout a)
        {
            var value = db.TblAbout.Find(a.AboutID);
            value.Title = a.Title;
            value.Header = a.Header;
            value.Description = a.Description;
            value.ImageUrl = a.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public void DownloadFile()
        {
            string filename = "cv (1).pdf";

            string filePath = AppDomain.CurrentDomain.BaseDirectory + "/Templates/" + filename;
            //string filePath = System.Web.HttpContext.Current.Server.MapPath(filename);

            HttpResponse res = System.Web.HttpContext.Current.Response;

            res.Clear();
            res.AppendHeader("content-disposition", "attachment; filename=" + filename);

            res.ContentType = "application/octet-stream";

            res.WriteFile(filePath);

            res.Flush();

            res.End();
        }
    }
}
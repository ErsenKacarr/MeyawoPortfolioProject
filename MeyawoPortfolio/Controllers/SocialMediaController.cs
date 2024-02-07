using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class SocialMediaController : Controller
    {
        DbMyPortfolioEntities5 db = new DbMyPortfolioEntities5();
        public ActionResult Index()
        {
            var values = db.TblSocialMedia.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateSocialMedia()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSocialMedia(TblSocialMedia s)
        {
            db.TblSocialMedia.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSocialMedia(int id)
        {
            var value = db.TblSocialMedia.Find(id);
            db.TblSocialMedia.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSocialMedia(int id)
        {
            var value = db.TblSocialMedia.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateSocialMedia(TblSocialMedia s)
        {
            var value = db.TblSocialMedia.Find(s.SocialMediaID);
            value.Title = s.Title;
            value.SocialMediaUrl = s.SocialMediaUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
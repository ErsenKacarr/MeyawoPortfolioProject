using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        DbMyPortfolioEntities5 db = new DbMyPortfolioEntities5();
        public ActionResult Index()
        {
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.projectCount = db.TblProject.Count();
            ViewBag.messageCount = db.TblContact.Count();
            ViewBag.flutterProjectCount = db.TblProject.Where(x => x.ProjectCategory == 1).Count();
            ViewBag.isReadMessageCount = db.TblContact.Where(x => x.IsRead == false).Count();
            ViewBag.lastProjectName = db.LastProjectName().FirstOrDefault();
            ViewBag.NameSurname = db.TblTestimonial.Count();
            ViewBag.TitleCount = db.TblSocialMedia.Count();
            ViewBag.TitleCount = db.TblService.Count();
            ViewBag.ReactNativeProjectCount = db.TblProject.Where(x => x.ProjectCategory == 6).Count();
            return View();
        }
    }
}
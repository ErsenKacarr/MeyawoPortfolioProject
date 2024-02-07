using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        DbMyPortfolioEntities5 db = new DbMyPortfolioEntities5();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult FuturePartial()
        {
            var values = db.TblFuture.ToList();
            return PartialView(values);
        }

        public PartialViewResult AboutPartial()
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }

        public PartialViewResult ServicePartial()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }

        public PartialViewResult TestimonialPartial()
        {
            var values = db.TblTestimonial.ToList();
            return PartialView(values);
        }

        public PartialViewResult ContactPartial()
        {
            var values = db.TblContact.ToList();
            return PartialView(values);
        }

        public PartialViewResult PortfolioPartial()
        {
            var values = db.TblCategory.ToList();
            return PartialView(values);
        }

        public PartialViewResult BlogPartial()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class DashboardController : Controller
    {
        DbMyPortfolioEntities5 db = new DbMyPortfolioEntities5();
        public ActionResult Index()
        {
            return View();
        }
    }
}
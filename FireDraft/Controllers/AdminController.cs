using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FireDraft.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Positions()
        {
            return View();
        }

        public ActionResult Athletes()
        {
            return View();
        }

        public ActionResult AthleticTeams()
        {
            return View();
        }

        public ActionResult League()
        {
            return View();
        }

        public ActionResult Users()
        {
            return View();
        }

        public ActionResult DraftStyle()
        {
            return View();
        }

        public ActionResult Settings()
        {
            return View();
        }

        public ActionResult LeagueSettings()
        {
            return View();
        }

        public ViewResult LeagueSettingsCreateEdit(string id)
        {
            return View();
        }
    }
}

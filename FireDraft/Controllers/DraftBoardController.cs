using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FireDraft.Controllers
{
    public class DraftBoardController : Controller
    {
        //
        // GET: /DraftBoard/

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Athletes()
        {
            return PartialView();
        }

        public PartialViewResult TopNav()
        {
            return PartialView();
        }

        public PartialViewResult SideNav()
        {
            return PartialView();
        }


    }
}

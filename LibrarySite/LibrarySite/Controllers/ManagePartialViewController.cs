using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibrarySite.Controllers
{
    public class ManagePartialViewController : Controller
    {
        // GET: ManagePartialView
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated == true)
            {
                return PartialView("_MenuDetailed");
            }
            else
            {
                return PartialView("_MenuBasic");
            }

        }

    }
}
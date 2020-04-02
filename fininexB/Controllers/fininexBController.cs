using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fininexB.Controllers
{
    public class fininexBController : Controller
    {
        public ActionResult HomePage()
        {
            return View();
        }

        public ActionResult Input()
        {
            return View();
        }

        public ActionResult Wallet()
        {
            return View();
        }
    }
}
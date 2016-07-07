using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWithEF.Controllers
{
    public class MvcEFController : Controller
    {
        // GET: MvcEF
        public ActionResult ProductInfo()
        {
            return View();
        }
    }
}
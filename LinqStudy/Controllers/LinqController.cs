using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LinqHelper;

namespace LinqStudy.Controllers
{
    public class LinqController : Controller
    {
        //
        // GET: /Linq/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Restriction()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Restriction(int id)
        {
            object res = null;
            if (id == 1)
            {
                res = new Restriction().Where1();
            }
            return View(res);
        }

    }
}

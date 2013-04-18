using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LinqHelper;
using System.Text;

namespace LinqStudy.Controllers
{
    public class LinqController : Controller
    {
        #region Restriction--Where语法
        public Restriction _restriction;
        public Restriction restriction
        {
            get
            {
                if (_restriction == null)
                    _restriction = new Restriction();
                return _restriction;
            }
        }       
        public ActionResult Restriction()
        {
            return View();
        }
        public ActionResult Restriction1()
        {
            ViewData["WhereSimple1"] = restriction.Linq1();
            ViewData["Anchor"] = "Linq1";
            return View("Restriction");
        }
        public ActionResult Restriction2()
        {
            ViewData["WhereSimple2"] = restriction.Linq2();
            ViewData["Anchor"] = "Linq2";
            return View("Restriction");
        }
        public ActionResult Restriction3()
        {
            ViewData["WhereSimple3"] = restriction.Linq3();
            ViewData["Anchor"] = "Linq3";
            return View("Restriction");
        }
        public ActionResult Restriction4()
        {
            ViewData["WhereSimple4"] = restriction.Linq4();
            ViewData["Anchor"] = "Linq4";
            return View("Restriction");
        }
        public ActionResult Restriction5()
        {
            ViewData["WhereSimple5"] = restriction.Linq5();
            ViewData["Anchor"] = "Linq5";
            return View("Restriction");
        }
        #endregion

        #region Restriction--Select语法
        #endregion

    }
}

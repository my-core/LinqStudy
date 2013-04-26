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

        #region Description--Select语法
        public Projection _description;
        public Projection description
        {
            get
            {
                if (_description == null)
                    _description = new Projection();
                return _description;
            }
        }
        public ActionResult Projection()
        {
            return View();
        }
        public ActionResult Projection1()
        {
            ViewData["SelectSimple1"] = description.Linq1();
            ViewData["Anchor"] = "Linq1";
            return View("Projection");
        }
        public ActionResult Projection2()
        {
            ViewData["SelectSimple2"] = description.Linq2();
            ViewData["Anchor"] = "Linq2";
            return View("Projection");
        }
        public ActionResult Projection3()
        {
            ViewData["SelectSimple3"] = description.Linq3();
            ViewData["Anchor"] = "Linq3";
            return View("Projection");
        }
        public ActionResult Projection4()
        {
            ViewData["SelectSimple4"] = description.Linq4();
            ViewData["Anchor"] = "Linq4";
            return View("Projection");
        }
        public ActionResult Projection5()
        {
            ViewData["SelectSimple5"] = description.Linq5();
            ViewData["Anchor"] = "Linq5";
            return View("Projection");
        }
        public ActionResult Projection6()
        {
            ViewData["SelectSimple6"] = description.Linq6();
            ViewData["Anchor"] = "Linq6";
            return View("Projection");
        }
        public ActionResult Projection7()
        {
            ViewData["SelectSimple7"] = description.Linq7();
            ViewData["Anchor"] = "Linq7";
            return View("Projection");
        }
        public ActionResult Projection8()
        {
            ViewData["SelectSimple8"] = description.Linq8();
            ViewData["Anchor"] = "Linq8";
            return View("Projection");
        }
        public ActionResult Projection9()
        {
            ViewData["SelectSimple9"] = description.Linq9();
            ViewData["Anchor"] = "Linq9";
            return View("Projection");
        }
        public ActionResult Projection10()
        {
            ViewData["SelectSimple10"] = description.Linq10();
            ViewData["Anchor"] = "Linq10";
            return View("Projection");
        }
        public ActionResult Projection11()
        {
            ViewData["SelectSimple11"] = description.Linq11();
            ViewData["Anchor"] = "Linq11";
            return View("Projection");
        }
        public ActionResult Projection12()
        {
            ViewData["SelectSimple12"] = description.Linq12();
            ViewData["Anchor"] = "Linq12";
            return View("Projection");
        }
        public ActionResult Projection13()
        {
            ViewData["SelectSimple13"] = description.Linq13();
            ViewData["Anchor"] = "Linq13 ";
            return View("Projection");
        }
        #endregion

        #region Partitioning--Take语法
        public Partitioning _partitioning;
        public Partitioning partitioning
        {
            get
            {
                if (_partitioning == null)
                    _partitioning = new Partitioning();
                return _partitioning;
            }
        }
        public ActionResult Partitioning()
        {
            return View();
        }
        public ActionResult Partitioning1()
        {
            ViewData["TakeSimple1"] = partitioning.Linq1();
            ViewData["Anchor"] = "Linq1";
            return View("Partitioning");
        }
        public ActionResult Partitioning2()
        {
            ViewData["TakeSimple2"] = partitioning.Linq2();
            ViewData["Anchor"] = "Linq2";
            return View("Partitioning");
        }
        public ActionResult Partitioning3()
        {
            ViewData["SkipSimple1"] = partitioning.Linq3();
            ViewData["Anchor"] = "Linq3";
            return View("Partitioning");
        }
        public ActionResult Partitioning4()
        {
            ViewData["SkipSimple2"] = partitioning.Linq4();
            ViewData["Anchor"] = "Linq4";
            return View("Partitioning");
        }
        public ActionResult Partitioning5()
        {
            ViewData["TaleWhileSimple1"] = partitioning.Linq5();
            ViewData["Anchor"] = "Linq5";
            return View("Partitioning");
        }
        public ActionResult Partitioning6()
        {
            ViewData["TaleWhileSimple2"] = partitioning.Linq6();
            ViewData["Anchor"] = "Linq6";
            return View("Partitioning");
        }
        public ActionResult Partitioning7()
        {
            ViewData["SkipWhileSimple1"] = partitioning.Linq7();
            ViewData["Anchor"] = "Linq7";
            return View("Partitioning");
        }
        public ActionResult Partitioning8()
        {
            ViewData["SkipWhileSimple2"] = partitioning.Linq8();
            ViewData["Anchor"] = "Linq8";
            return View("Partitioning");
        }
        #endregion

        #region Ordering--OrderBy/ThenBy/OrderByDescending/ThenByDescending语法
        public Ordering _ordering;
        public Ordering ordering
        {
            get
            {
                if (_ordering == null)
                    _ordering = new Ordering();
                return _ordering;
            }
        }
        public ActionResult Ordering()
        {
            return View();
        }
        public ActionResult Ordering1()
        {
            ViewData["OrderBySimple1"] = ordering.Linq1();
            ViewData["Anchor"] = "Linq1";
            return View("Ordering");
        }
        public ActionResult Ordering2()
        {
            ViewData["OrderBySimple2"] = ordering.Linq2();
            ViewData["Anchor"] = "Linq2";
            return View("Ordering");
        }
        public ActionResult Ordering3()
        {
            ViewData["OrderBySimple3"] = ordering.Linq3();
            ViewData["Anchor"] = "Linq3";
            return View("Ordering");
        }
        public ActionResult Ordering4()
        {
            ViewData["OrderBySimple4"] = ordering.Linq4();
            ViewData["Anchor"] = "Linq4";
            return View("Ordering");
        }
        public ActionResult Ordering5()
        {
            ViewData["OrderByDescending1"] = ordering.Linq5();
            ViewData["Anchor"] = "Linq5";
            return View("Ordering");
        }
        public ActionResult Ordering6()
        {
            ViewData["OrderByDescending2"] = ordering.Linq6();
            ViewData["Anchor"] = "Linq6";
            return View("Ordering");
        }
        public ActionResult Ordering7()
        {
            ViewData["OrderByDescending3"] = ordering.Linq7();
            ViewData["Anchor"] = "Linq7";
            return View("Ordering");
        }
        public ActionResult Ordering8()
        {
            ViewData["ThenBy1"] = ordering.Linq8();
            ViewData["Anchor"] = "Linq8";
            return View("Ordering");
        }
        public ActionResult Ordering9()
        {
            ViewData["ThenBy2"] = ordering.Linq9();
            ViewData["Anchor"] = "Linq9";
            return View("Ordering");
        }
        #endregion

        public Grouping _grouping;
        public Grouping grouping
        {
            get
            {
                if (_grouping == null)
                    _grouping = new Grouping();
                return _grouping;
            }
        }
        public ActionResult Grouping()
        {
            return View();
        }
        public ActionResult Grouping4()
        {
            ViewData["GroupingSample4"] = grouping.Linq4();
            ViewData["Anchor"] = "Linq4";
            return View("Grouping");
        }



    }
}

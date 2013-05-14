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
        public ActionResult Ordering10()
        {
            ViewData["ThenByDescending1"] = ordering.Linq10();
            ViewData["Anchor"] = "Linq10";
            return View("Ordering");
        }
        public ActionResult Ordering11()
        {
            ViewData["ThenByDescending2"] = ordering.Linq11();
            ViewData["Anchor"] = "Linq11";
            return View("Ordering");
        }
        #endregion

        #region Grouping--GroupBy语法
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
        public ActionResult Grouping1()
        {
            ViewData["GroupingSample1"] = grouping.Linq1();
            ViewData["Anchor"] = "Linq1";
            return View("Grouping");
        }
        public ActionResult Grouping2()
        {
            ViewData["GroupingSample2"] = grouping.Linq2();
            ViewData["Anchor"] = "Linq2";
            return View("Grouping");
        }
        public ActionResult Grouping3()
        {
            ViewData["GroupingSample3"] = grouping.Linq3();
            ViewData["Anchor"] = "Linq3";
            return View("Grouping");
        }
        public ActionResult Grouping4()
        {
            ViewData["GroupingSample4"] = grouping.Linq4();
            ViewData["Anchor"] = "Linq4";
            return View("Grouping");
        }
        public ActionResult Grouping5()
        {
            ViewData["GroupingSample5"] = grouping.Linq5();
            ViewData["Anchor"] = "Linq5";
            return View("Grouping");
        }
        public ActionResult Grouping6()
        {
            ViewData["GroupingSample6"] = grouping.Linq6();
            ViewData["Anchor"] = "Linq6";
            return View("Grouping");
        }
        #endregion

        #region Set--Distinct/Union/Intersect/Except语法
        public Set _set;
        public Set set
        {
            get
            {
                if (_set == null)
                    _set = new Set();
                return _set;
            }
        }
        public ActionResult Set()
        {
            return View();
        }
        public ActionResult Set1()
        {
            ViewData["DistinctSample1"] = set.Linq1();
            ViewData["Anchor"] = "Linq1";
            return View("Set");
        }
        public ActionResult Set2()
        {
            ViewData["DistinctSample2"] = set.Linq2();
            ViewData["Anchor"] = "Linq2";
            return View("Set");
        }
        public ActionResult Set3()
        {
            ViewData["UnionSample1"] = set.Linq3();
            ViewData["Anchor"] = "Linq3";
            return View("Set");
        }
        public ActionResult Set4()
        {
            ViewData["UnionSample2"] = set.Linq4();
            ViewData["Anchor"] = "Linq4";
            return View("Set");
        }
        public ActionResult Set5()
        {
            ViewData["IntersectSample1"] = set.Linq5();
            ViewData["Anchor"] = "Linq5";
            return View("Set");
        }
        public ActionResult Set6()
        {
            ViewData["IntersectSample2"] = set.Linq6();
            ViewData["Anchor"] = "Linq6";
            return View("Set");
        }

        #endregion

        #region Conversion--ToArray/ToList/ToDictionary/OfType语法
        public Conversion _conversion;
        public Conversion conversion
        {
            get
            {
                if (_conversion == null)
                    _conversion = new Conversion();
                return _conversion;
            }
        }
        public ActionResult Conversion()
        {
            return View();
        }
        public ActionResult Conversion1()
        {
            ViewData["ConversionSample1"] = conversion.Linq1();
            ViewData["Anchor"] = "Linq1";
            return View("Conversion");
        }
        public ActionResult Conversion2()
        {
            ViewData["ConversionSample2"] = conversion.Linq2();
            ViewData["Anchor"] = "Linq2";
            return View("Conversion");
        }
        public ActionResult Conversion3()
        {
            ViewData["ConversionSample3"] = conversion.Linq3();
            ViewData["Anchor"] = "Linq3";
            return View("Conversion");
        }
        public ActionResult Conversion4()
        {
            ViewData["ConversionSample4"] = conversion.Linq4();
            ViewData["Anchor"] = "Linq4";
            return View("Conversion");
        }
        #endregion

        #region Element--First/FirstOrDefault/ElementAt语法
        public Element _element;
        public Element element
        {
            get
            {
                if (_element == null)
                    _element = new Element();
                return _element;
            }
        }
        public ActionResult Element()
        {
            return View();
        }
        public ActionResult Element1()
        {
            ViewData["ElementSample1"] = element.Linq1();
            ViewData["Anchor"] = "Linq1";
            return View("Element");
        }
        public ActionResult Element2()
        {
            ViewData["ElementSample2"] = element.Linq2();
            ViewData["Anchor"] = "Linq2";
            return View("Element");
        }
        public ActionResult Element3()
        {
            ViewData["ElementSample3"] = element.Linq3();
            ViewData["Anchor"] = "Linq3";
            return View("Element");
        }
        public ActionResult Element4()
        {
            ViewData["ElementSample4"] = element.Linq4();
            ViewData["Anchor"] = "Linq4";
            return View("Element");
        }
        public ActionResult Element5()
        {
            ViewData["ElementSample5"] = element.Linq5();
            ViewData["Anchor"] = "Linq5";
            return View("Element");
        }
        #endregion

        #region Generation--Range/Repeat语法
        public Generation _generation;
        public Generation generation
        {
            get
            {
                if (_generation == null)
                    _generation = new Generation();
                return _generation;
            }
        }
        public ActionResult Generation()
        {
            return View();
        }
        public ActionResult Generation1()
        {
            ViewData["GenerationSample1"] = generation.Linq1();
            ViewData["Anchor"] = "Linq1";
            return View("Generation");
        }
        public ActionResult Generation2()
        {
            ViewData["GenerationSample2"] = generation.Linq2();
            ViewData["Anchor"] = "Linq2";
            return View("Generation");
        }       
        #endregion

        #region Quantifiers--Any/All语法
        public Quantifiers _quantifiers;
        public Quantifiers quantifiers
        {
            get
            {
                if (_quantifiers == null)
                    _quantifiers = new Quantifiers();
                return _quantifiers;
            }
        }
        public ActionResult Quantifiers()
        {
            return View();
        }
        public ActionResult Quantifiers1()
        {
            ViewData["QuantifiersSample1"] = quantifiers.Linq1();
            ViewData["Anchor"] = "Linq1";
            return View("Quantifiers");
        }
        public ActionResult Quantifiers2()
        {
            ViewData["QuantifiersSample2"] = quantifiers.Linq2();
            ViewData["Anchor"] = "Linq2";
            return View("Quantifiers");
        }
        #endregion

        #region Aggregate--Count/Sum/Min/Max/Average/Aggregate/语法
        public Aggregate _aggregate;
        public Aggregate aggregate
        {
            get
            {
                if (_aggregate == null)
                    _aggregate = new Aggregate();
                return _aggregate;
            }
        }
        public ActionResult Aggregate()
        {
            return View();
        }
        public ActionResult Aggregate1()
        {
            ViewData["AggregateSample1"] = aggregate.Linq1();
            ViewData["Anchor"] = "Linq1";
            return View("Aggregate");
        }
        public ActionResult Aggregate2()
        {
            ViewData["AggregateSample2"] = aggregate.Linq2();
            ViewData["Anchor"] = "Linq2";
            return View("Aggregate");
        }
        public ActionResult Aggregate3()
        {
            ViewData["AggregateSample3"] = aggregate.Linq3();
            ViewData["Anchor"] = "Linq3";
            return View("Aggregate");
        }
        public ActionResult Aggregate4()
        {
            ViewData["AggregateSample4"] = aggregate.Linq4();
            ViewData["Anchor"] = "Linq4";
            return View("Aggregate");
        }
        public ActionResult Aggregate5()
        {
            ViewData["AggregateSample5"] = aggregate.Linq5();
            ViewData["Anchor"] = "Linq5";
            return View("Aggregate");
        }
        public ActionResult Aggregate6()
        {
            ViewData["AggregateSample6"] = aggregate.Linq6();
            ViewData["Anchor"] = "Linq6";
            return View("Aggregate");
        }
        public ActionResult Aggregate7()
        {
            ViewData["AggregateSample7"] = aggregate.Linq7();
            ViewData["Anchor"] = "Linq7";
            return View("Aggregate");
        }
        public ActionResult Aggregate8()
        {
            ViewData["AggregateSample8"] = aggregate.Linq8();
            ViewData["Anchor"] = "Linq8";
            return View("Aggregate");
        }
        public ActionResult Aggregate9()
        {
            ViewData["AggregateSample9"] = aggregate.Linq9();
            ViewData["Anchor"] = "Linq9";
            return View("Aggregate");
        }
        public ActionResult Aggregate10()
        {
            ViewData["AggregateSample10"] = aggregate.Linq10();
            ViewData["Anchor"] = "Linq10";
            return View("Aggregate");
        }
        public ActionResult Aggregate11()
        {
            ViewData["AggregateSample11"] = aggregate.Linq11();
            ViewData["Anchor"] = "Linq11";
            return View("Aggregate");
        }
        public ActionResult Aggregate12()
        {
            ViewData["AggregateSample12"] = aggregate.Linq12();
            ViewData["Anchor"] = "Linq12";
            return View("Aggregate");
        }
        public ActionResult Aggregate13()
        {
            ViewData["AggregateSample13"] = aggregate.Linq13();
            ViewData["Anchor"] = "Linq13";
            return View("Aggregate");
        }
        public ActionResult Aggregate14()
        {
            ViewData["AggregateSample14"] = aggregate.Linq14();
            ViewData["Anchor"] = "Linq14";
            return View("Aggregate");
        }
        public ActionResult Aggregate15()
        {
            ViewData["AggregateSample15"] = aggregate.Linq15();
            ViewData["Anchor"] = "Linq15";
            return View("Aggregate");
        }
        public ActionResult Aggregate16()
        {
            ViewData["AggregateSample16"] = aggregate.Linq16();
            ViewData["Anchor"] = "Linq16";
            return View("Aggregate");
        }
        public ActionResult Aggregate17()
        {
            ViewData["AggregateSample17"] = aggregate.Linq17();
            ViewData["Anchor"] = "Linq17";
            return View("Aggregate");
        }
        public ActionResult Aggregate18()
        {
            ViewData["AggregateSample18"] = aggregate.Linq18();
            ViewData["Anchor"] = "Linq18";
            return View("Aggregate");
        }
        public ActionResult Aggregate19()
        {
            ViewData["AggregateSample19"] = aggregate.Linq19();
            ViewData["Anchor"] = "Linq19";
            return View("Aggregate");
        }
        public ActionResult Aggregate20()
        {
            ViewData["AggregateSample20"] = aggregate.Linq20();
            ViewData["Anchor"] = "Linq20";
            return View("Aggregate");
        }
        #endregion

        #region Miscellaneous-Concat/EqualAll语法
        public Miscellaneous _miscellaneous;
        public Miscellaneous miscellaneous
        {
            get
            {
                if (_miscellaneous == null)
                    _miscellaneous = new Miscellaneous();
                return _miscellaneous;
            }
        }
        public ActionResult Miscellaneous()
        {
            return View();
        }
        public ActionResult Miscellaneous1()
        {
            ViewData["MiscellaneousSample1"] = miscellaneous.Linq1();
            ViewData["Anchor"] = "Linq1";
            return View("Miscellaneous");
        }
        public ActionResult Miscellaneous2()
        {
            ViewData["MiscellaneousSample2"] = miscellaneous.Linq2();
            ViewData["Anchor"] = "Linq2";
            return View("Miscellaneous");
        }
        public ActionResult Miscellaneous3()
        {
            ViewData["MiscellaneousSample3"] = miscellaneous.Linq3();
            ViewData["Anchor"] = "Linq3";
            return View("Miscellaneous");
        }
        public ActionResult Miscellaneous4()
        {
            ViewData["MiscellaneousSample4"] = miscellaneous.Linq4();
            ViewData["Anchor"] = "Linq4";
            return View("Miscellaneous");
        }
        #endregion

    
    }
}

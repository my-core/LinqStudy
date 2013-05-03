using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqHelper
{
    public class Ordering
    {
        public DataConstructor data = new DataConstructor();
        /// <summary>
        /// 对数组中元素进行排序
        /// </summary>
        /// <returns></returns>
        public string Linq1()
        {
            StringBuilder sb = new StringBuilder();
            string[] words = { "cherry", "apple", "blueberry" };
            var sortedWords =
                from w in words
                orderby w
                select w;
            sb.Append("对数组中元素进行升序排序：");
            foreach (var w in sortedWords)
            {
                sb.Append(w + " ");
            }
            return sb.ToString();
        }
        /// <summary>
        /// 对数组中元素按元素长度进行升序排序
        /// </summary>
        /// <returns></returns>
        public object Linq2()
        {
            StringBuilder sb = new StringBuilder();
            string[] words = { "cherry", "apple", "blueberry" };
            var sortedWords =
               from w in words
               orderby w.Length
               select w;
            sb.Append("对数组中元素按元素长度进行升序排序：");
            foreach (var w in sortedWords)
            {
                sb.Append(w + " ");
            }
            return sb.ToString();
        }
        /// <summary>
        /// 按产品名对产品列表进行升序排序
        /// </summary>
        /// <returns></returns>
        public object Linq3()
        {
            List<string> list = new List<string>();
            List<Product> product = data.GetProductList();
            var sortP =
                from p in product
                orderby p.ProductName
                select p;
            foreach(var p in sortP)
            {
                list.Add(String.Format("ProductID={0} ProductName={1} Category={2} UnitPrice={3} UnitsInStock={4}", p.ProductID, p.ProductName, p.Category, p.UnitPrice, p.UnitsInStock));
            }
            return list;
        }
        /// <summary>
        /// 使用比较器进行升序排序
        /// </summary>
        /// <returns></returns>
        public object Linq4()
        {
            StringBuilder sb = new StringBuilder();
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortedWords = words.OrderBy(a => a, new CaseInsensitiveComparer());
            sb.Append("使用比较器进行升序排序:");
            foreach (var w in sortedWords)
            {
                sb.Append(w + " ");
            }
            return sb.ToString();
        }
        /// <summary>
        /// 对数组里的数据进行降序排序
        /// </summary>
        /// <returns></returns>
        public object Linq5()
        {
            StringBuilder sb = new StringBuilder();
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };
            var sortedDoubles =
                from d in doubles
                orderby d descending
                select d;
            sb.Append("对数组里的数据进行降序排序:");
            foreach (var d in sortedDoubles)
            {
                sb.Append(d + " ");
            }
            return sb.ToString();
        }
        /// <summary>
        /// 按产品库存大小进行降序排序
        /// </summary>
        /// <returns></returns>
        public object Linq6()
        {
            List<string> list = new List<string>();
            List<Product> product = data.GetProductList();
            var sortP =
                from p in product
                orderby p.UnitsInStock descending
                select p;
            foreach (var p in sortP)
            {
                list.Add(String.Format("ProductID={0} ProductName={1} UnitsInStock={2}", p.ProductID, p.ProductName, p.UnitsInStock));
            }
            return list;
        }
        /// <summary>
        /// 使用比较器进行降序排序
        /// </summary>
        /// <returns></returns>
        public object Linq7()
        {
            StringBuilder sb = new StringBuilder();
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortedWords = words.OrderByDescending(a => a, new CaseInsensitiveComparer());
            sb.Append("使用比较器进行降序排序:");
            foreach (var w in sortedWords)
            {
                sb.Append(w + " ");
            }
            return sb.ToString();
        }
        /// <summary>
        /// 对数组按两个条件进行排序
        /// </summary>
        /// <returns></returns>
        public object Linq8()
        {
            StringBuilder sb = new StringBuilder();
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var sortedDigits =
                from d in digits
                orderby d.Length,d
                select d;
            //var sortedDigits = digits.OrderBy(d => d.Length).ThenBy(d => d);
            sb.Append("使用ThenBy对数组按两个条件进行排序：");
            foreach (var d in sortedDigits)
            {
                sb.Append(d + " ");
            }
            return sb.ToString();
        }
        /// <summary>
        /// 使用ThenBy配合比较器对数组按两个条件进行排序
        /// </summary>
        /// <returns></returns>
        public object Linq9()
        {
            StringBuilder sb = new StringBuilder();
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortedWords = words.OrderBy(w => w.Length).ThenBy(w => w,new CaseInsensitiveComparer());
            sb.Append("使用ThenBy配合比较器对数组按两个条件进行排序：");
            foreach (var w in sortedWords)
            {
                sb.Append(w + " ");
            }
            return sb.ToString();
        }
        /// <summary>
        /// 按产品分类升序、产品价格降序进行排序
        /// </summary>
        /// <returns></returns>
        public object Linq10()
        {
            List<string> list = new List<string>();
            List<Product> product = data.GetProductList();
            var sortedP =
                from p in product
                orderby p.Category, p.UnitPrice descending
                select p;
            //var sortedP = product.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            foreach (var p in sortedP)
            {
                list.Add(String.Format(" ProductName={0} ; Category={1} ; UnitPrice={2} ", p.ProductName,p.Category,p.UnitPrice));
            }
            return list;
        }
        /// <summary>
        /// 用ThenByDescending配合比较器对数组按长度升序、按字母降序进行排序
        /// </summary>
        /// <returns></returns>
        public object Linq11()
        {
            StringBuilder sb = new StringBuilder();
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortedWords =
               words.OrderBy(w => w.Length).ThenBy(w => w, new CaseInsensitiveComparer());
            sb.Append("用ThenByDescending配合比较器对数组按长度升序、按字母降序进行排序：");
            foreach (var w in sortedWords)
            {
                sb.Append(w + " ");
            }
            return sb.ToString();
        }
    }
    public class CaseInsensitiveComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
        }
    }
}

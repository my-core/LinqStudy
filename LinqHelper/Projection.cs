using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
namespace LinqHelper
{
    /// <summary>
    /// 映射 -- Select语法使用
    /// </summary>
    public class Projection
    {
        public DataConstructor data = new DataConstructor();
        [Description("对每一项元素加1")]
        public string Linq1()
        {
            StringBuilder sb = new StringBuilder();
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numsPlusOne =
                from n in numbers
                select n + 1;
            sb.Append("对每一项元素加1后：");
            foreach (var x in numsPlusOne)
            {
                sb.Append(x + " ");
            }
            return sb.ToString();
        }
        [Description("获取所有产品名集合")]
        public string Linq2()
        {
            StringBuilder sb = new StringBuilder();
            List<Product> products = data.GetProductList();
            var productNames =
                from p in products
                select p.ProductName;
            foreach (string s in productNames)
            {
                sb.Append(s + " ");
            }
            return sb.ToString();
        }
        [Description("选择产生一系列的字符串代表一个整数序列的文本版本")]
        public string Linq3()
        {
            StringBuilder sb = new StringBuilder();
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var textNums =
                from n in numbers
                select strings[n];
            sb.Append("选择产生一系列的字符串代表一个整数序列的文本版本：");
            foreach (string s in textNums)
            {
                sb.Append(s + " ");
            }
            return sb.ToString();
        }
        [Description("选择产生一系列原始数组中的每一个字的大写和小写版本")]
        public string Linq4()
        {
            StringBuilder sb = new StringBuilder();
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            var upperLowerWords =
                from w in words
                select new { Upper = w.ToUpper(), Lower = w.ToLower() };
            sb.Append("选择产生一系列原始数组中的每一个字的大写和小写版本：");
            foreach (var s in upperLowerWords)
            {
                sb.AppendFormat("<br/>Uppercase:{0},Lowercase:{1}", s.Upper, s.Lower);
            }
            return sb.ToString();
        }
        [Description("选择产生一系列包含文字表示的数字和它们的长度是否是偶数还是奇数")]
        public string Linq5()
        {
            StringBuilder sb = new StringBuilder();
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var digitOddEvens =
                from n in numbers
                select new { Digit = strings[n], Even = (n % 2 == 0) };
            sb.Append("选择产生一系列包含文字表示的数字和它们的长度是否是偶数还是奇数：");
            foreach (var s in digitOddEvens)
            {
                sb.AppendFormat("<br/>数字{0}是{1}.", s.Digit, s.Even ? "偶数" : "奇数");
            }
            return sb.ToString();
        }
        [Description("对产品中的属性UnitPrice进行重名成Price")]
        public dynamic Linq6()
        {
            List<Products> list = new List<Products>();
            List<Product> products = data.GetProductList();
            var productInfos =
                from p in products
                select new { p.ProductName, p.Category, Price = p.UnitPrice };
            foreach (var productInfo in productInfos)
            {
                Products p = new Products();
                p.ProductName = productInfo.ProductName;
                p.Category = productInfo.Category;
                p.Price = productInfo.Price;
                list.Add(p);
            }
            return list;
        }
        
    }
    public class Products
    {
        public string ProductName;
        public string Category;
        public decimal Price;

    }
 
}

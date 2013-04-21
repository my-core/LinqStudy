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
        public List<string> Linq5()
        {
            List<string> list = new List<string>();
            StringBuilder sb = new StringBuilder();
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var digitOddEvens =
                from n in numbers
                select new { Digit = strings[n], Even = (n % 2 == 0) };
            sb.Append("选择产生一系列包含文字表示的数字和它们的长度是否是偶数还是奇数：");
            foreach (var s in digitOddEvens)
            {
                list.Add(String.Format("数字{0}是{1}.", s.Digit, s.Even ? "偶数" : "奇数"));
            }
            return list;
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
        [Description("产生一系列数字及数字的值是否等于索引")]
        public List<string> Linq7()
        {
            List<string> list = new List<string>();
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var numsInPlace = numbers.Select((num, index) => new { Num = num, InPlace = (num == index) });
            foreach (var n in numsInPlace)
            {
                list.Add(String.Format("{0}: {1}", n.Num, n.InPlace));
            }
            return list;
        }
        [Description("产生一系列索引小于5的数组元素")]
        public List<string> Linq8()
        {
            List<string> list = new List<string>();
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var numsInPlace =
                from n in numbers
                where n < 5
                select digits[n];
            foreach (var n in numsInPlace)
            {
                list.Add(n);
            }
            return list;
        }
        [Description("产生两个数组中值对比的复合数据")]
        public List<string> Linq9()
        {
            List<string> list = new List<string>();
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var pairs =
                from a in numbersA
                from b in numbersB
                where a < b
                select new { a,b};
            foreach (var p in pairs)
            {
                list.Add(String.Format("{0} is less than {1}", p.a, p.b));
            }
            return list;
        }
        public List<string> Linq10()
        {
            List<string> list = new List<string>();
            List<Customer> customers = data.GetCustomerList();
            var orders =
                from c in customers
                from o in c.Orders
                where o.Total < 50.00M
                select new { c.CustomerID, o.OrderID, o.Total };
            foreach (var p in orders)
            {
                list.Add(String.Format("CustomerID={0},OrderID={1},Total={2}",p.CustomerID,p.OrderID,p.Total));
            }
            return list;
        }
        public List<string> Linq11()
        {
            List<string> list = new List<string>();
            List<Customer> customers = data.GetCustomerList();
            var orders =
                from c in customers
                from o in c.Orders
                where o.OrderDate >= new DateTime(1998, 5, 1)
                select new { c.CustomerID, o.OrderID, o.OrderDate };
            foreach (var p in orders)
            {
                list.Add(String.Format("CustomerID={0},OrderID={1},OrderDate={2}", p.CustomerID, p.OrderID, p.OrderDate));
            }
            return list;
        }
        public List<string> Linq12()
        {
            List<string> list = new List<string>();
            List<Customer> customers = data.GetCustomerList();
            var orders =
                from c in customers
                where c.Region == "WA"
                from o in c.Orders
                where o.OrderDate >= new DateTime(1998, 1, 1)
                select new { c.CustomerID, o.OrderID, };
            foreach (var p in orders)
            {
                list.Add(String.Format("CustomerID={0},OrderID={1}", p.CustomerID, p.OrderID));
            }
            return list;
        }
        public List<string> Linq13()
        {
            List<string> list = new List<string>();
            List<Customer> customers = data.GetCustomerList();
            var customerOrders =
                customers.SelectMany(
                    (cust, custIndex) =>
                    cust.Orders.Select(o => "Customer #" + (custIndex + 1) +
                                            " has an order with OrderID " + o.OrderID));
            foreach (var p in customerOrders)
            {
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

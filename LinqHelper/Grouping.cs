﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace LinqHelper
{
    public class Grouping
    {
        public DataConstructor data = new DataConstructor();
        [Description("按数组元素除5的余数进行分组")]
        public List<string> Linq1()
        {
            List<string> list = new List<string>();
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numberGroups =
               from n in numbers
               group n by n % 5 into g
               select new { Remainder = g.Key, Numbers = g };

            foreach (var g in numberGroups)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("除以5余数为{0}的元素有:",g.Remainder);
                foreach (var n in g.Numbers)
                {
                    sb.Append(n + "  ");
                }
                list.Add(sb.ToString());
            }
            return list;
        }
        [Description("按数组元素的首字母进行分组")]
        public object Linq2()
        {                   
            List<string> list = new List<string>();
            string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };

            var wordGroups =
               from w in words
               group w by w[0] into g
               select new { FirstLetter = g.Key, Words = g };

            foreach (var g in wordGroups)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("首字母为{0}的元素有:",g.FirstLetter);
                foreach (var w in g.Words)
                {
                    sb.Append(w + "  ");
                }
                list.Add(sb.ToString());
            }
            return list;
        }

        public object Linq3()
        {
            List<string> list = new List<string>();
            List<Product> product = data.GetProductList();
            var orderGroups =
                from p in product
                group p by p.Category into g
                select new { Category = g.Key, Products = g };
            foreach (var g in orderGroups)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("分类为{0}的产品有：", g.Category);
                foreach (var p in g.Products)
                {
                    sb.Append(p.ProductName + "  ");
                }
            }
            return list;
        }

        public object Linq4()
        {
            List<Customer> customers = data.GetCustomerList();
             List<string> list = new List<string>();
            var customerOrderGroups =
                from c in customers
                select
                    new
                    {
                        c.CompanyName,
                        YearGroups =
                            from o in c.Orders
                            group o by o.OrderDate.Year into yg
                            select
                                new
                                {
                                    Year = yg.Key,
                                    MonthGroups =
                                        from o in yg
                                        group o by o.OrderDate.Month into mg
                                        select new { Month = mg.Key, Orders = mg }
                                }
                    };
            foreach (var c in customerOrderGroups)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("CompanyName:" + c.CompanyName + "<br/>");
                foreach (var y in c.YearGroups)
                {
                    sb.Append("--Year:" + y.Year + "<br/>");
                    foreach (var m in y.MonthGroups)
                    {
                        sb.Append("----Month:" + m.Month + "<br/>");
                        foreach (var o in m.Orders)
                        {
                            sb.Append("------OrderID:" + o.OrderID + ";OrderData:" + o.OrderDate + "Total:" + o.Total + "<br/>");
                        }
                    }
                }
                list.Add(sb.ToString());
            }
            return list;
        }

        public object Linq5()
        {
            throw new NotImplementedException();
        }

        public object Linq6()
        {
            throw new NotImplementedException();
        }

        public object Linq7()
        {
            throw new NotImplementedException();
        }

        public object Linq8()
        {
            throw new NotImplementedException();
        }

        public object Linq9()
        {
            throw new NotImplementedException();
        }
    }
}
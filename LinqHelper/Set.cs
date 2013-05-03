using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqHelper
{
    public class Set
    {
        public DataConstructor data = new DataConstructor();
        /// <summary>
        /// 将数组中重复的元素过滤掉
        /// </summary>
        /// <returns></returns>
        public object Linq1()
        {
            StringBuilder sb = new StringBuilder();
            int[] filterArr = { 2, 2, 3, 5, 5 };
            var filter = filterArr.Distinct();
            sb.Append("将数组中重复的元素过滤掉:");
            foreach (var f in filter)
            {
                sb.Append(f + " ");
            }
            return sb.ToString();
        }
        /// <summary>
        /// 使用Distinct过滤出产品列表中唯一的类别名
        /// </summary>
        /// <returns></returns>
        public object Linq2()
        {
            StringBuilder sb = new StringBuilder();
            List<Product> product = data.GetProductList();
            var categoryNames =
                (
                    from p in product
                    select p.Category
                ).Distinct();
            sb.Append("使用Distinct过滤出产品列表中唯一的类别名:");
            foreach (var c in categoryNames)
            {
                sb.Append(c + "； ");
            }
            return sb.ToString();
        }
        /// <summary>
        /// 这个示例使用Union获取包含来自两个数组的值的集合
        /// </summary>
        /// <returns></returns>
        public object Linq3()
        {
            StringBuilder sb = new StringBuilder();
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var union = numbersA.Union(numbersB);
            sb.Append("这个示例使用Union获取包含来自两个数组的值的集合:");
            foreach (var u in union)
            {
                sb.Append(u + " ");
            }
            return sb.ToString();
        }
        /// <summary>
        /// 使用Union获取包含来自产品和客户名称的第一个字母的集合
        /// </summary>
        /// <returns></returns>
        public object Linq4()
        {
            StringBuilder sb = new StringBuilder();
            List<Product> product = data.GetProductList();
            List<Customer> customer = data.GetCustomerList();
            var productFirstChars =
                from p in product
                select p.ProductName[0];
            var customerFirstChars =
                from c in customer
                select c.CompanyName[0];
            var union = productFirstChars.Union(customerFirstChars);
            sb.Append("产品名第一个字母集合：");
            foreach (var p in productFirstChars)
            {
                sb.Append(p + " ");
            }
            sb.Append("<br/>客户名第一个字母集合：");
            foreach (var c in customerFirstChars)
            {
                sb.Append(c + " ");
            }
            sb.Append("<br/>使用Union获取包含来自产品和客户名称的第一个字母的集合:");
            foreach (var u in union)
            {
                sb.Append(u + " ");
            }
            return sb.ToString();
        }
        /// <summary>
        /// 使用Intersect获取包含了两个数组共有的共元素集合
        /// </summary>
        /// <returns></returns>
        public object Linq5()
        {
            StringBuilder sb = new StringBuilder();
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var union = numbersA.Intersect(numbersB);
            sb.Append("使用Intersect获取包含了两个数组共有的共元素集合:");
            foreach (var u in union)
            {
                sb.Append(u + " ");
            }
            return sb.ToString();
        }
        /// <summary>
        /// 这个示例使用Intersect获取产品和客户名称的第一个字母集合中拥有相同元素的集合
        /// </summary>
        /// <returns></returns>
        public object Linq6()
        {
            StringBuilder sb = new StringBuilder();
            List<Product> product = data.GetProductList();
            List<Customer> customer = data.GetCustomerList();
            var productFirstChars =
                from p in product
                select p.ProductName[0];
            var customerFirstChars =
                from c in customer
                select c.CompanyName[0];
            var union = productFirstChars.Intersect(customerFirstChars);
            sb.Append("产品名第一个字母集合：");
            foreach (var p in productFirstChars)
            {
                sb.Append(p + " ");
            }
            sb.Append("<br/>客户名第一个字母集合：");
            foreach (var c in customerFirstChars)
            {
                sb.Append(c + " ");
            }
            sb.Append("<br/>使用Intersect获取产品和客户名称的第一个字母集合中拥有相同元素的集合:");
            foreach (var u in union)
            {
                sb.Append(u + " ");
            }
            return sb.ToString();
        }
    }
}

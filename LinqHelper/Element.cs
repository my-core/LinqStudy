using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqHelper
{
    public class Element
    {
        public DataConstructor data = new DataConstructor();
        /// <summary>
        /// 将返回序列中满足条件的第一个元素（无参）
        /// </summary>
        /// <returns></returns>
        public object Linq1()
        {
            StringBuilder sb = new StringBuilder();
            List<Product> products = data.GetProductList();
            //var product =
            //    (
            //        from p in products
            //        where p.ProductID == 12
            //        select p
            //    ).First();
            var product =
                (
                    from p in products
                    select p
                ).First(p => p.ProductID == 12);
            sb.Append("返回序列中满足条件（ProductID == 12）的第一个元素:");
            sb.AppendFormat("ProductID={0},ProductName={1}", product.ProductID, product.ProductName);
            return sb.ToString();
        }
        /// <summary>
        /// 将返回序列中满足条件的第一个元素（有参）
        /// </summary>
        /// <returns></returns>
        public object Linq2()
        {
            StringBuilder sb = new StringBuilder();
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string startsWithO = strings.First(s => s[0] == 't');
            sb.Append("返回序列中满足条件（s[0] == 't'）的第一个元素:");
            sb.Append(startsWithO);
            return sb.ToString();
        }
        /// <summary>
        /// 将返回序列中满足条件的第一个元素,如果序列中不包含任何元素，则返回默认值(无参)
        /// </summary>
        /// <returns></returns>
        public object Linq3()
        {
            StringBuilder sb = new StringBuilder();
            int[] strings = { };
            int startsWithO = strings.FirstOrDefault();
            sb.AppendFormat("返回序列中满足条件的第一个元素,如果序列中不包含任何元素，则返回默认值:{0}",startsWithO);
            return sb.ToString();
        }
        /// <summary>
        /// 将返回序列中满足条件的第一个元素,如果序列中不包含任何元素，则返回默认值（有参）
        /// </summary>
        /// <returns></returns>
        public object Linq4()
        {
            StringBuilder sb = new StringBuilder();
            List<Product> products = data.GetProductList();
            var product = products.FirstOrDefault(p => p.ProductID == 789);
            sb.AppendFormat("是否存在ID为789的产品:{0}", products != null);
            return sb.ToString();
        }
        /// <summary>
        /// 使用Intersect获取包含了两个数组共有的共元素集合
        /// </summary>
        /// <returns></returns>
        public object Linq5()
        {
            StringBuilder sb = new StringBuilder();
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var num =
                (
                    from n in numbers
                    where n > 5
                    select n
                ).ElementAt(1);
            sb.AppendFormat("数组中大于5的第二个元素是: {0}",num);            
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

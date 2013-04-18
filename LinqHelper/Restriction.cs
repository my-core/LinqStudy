using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace LinqHelper
{
    public class Restriction
    {
        
        public DataConstructor data = new DataConstructor();
        [Description("获取数组中小于5的元素")]
        public string Linq1()
        {
            int[] arr = { };
            StringBuilder sb = new StringBuilder();
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var lowNums =
                from num in numbers
                where num < 5
                select num;
            sb.Append("数据组中值小于5的元素：");
            foreach (var x in lowNums)
            {
                sb.Append(x + " ");
            }
            return sb.ToString();
        }

        [Description("获取库存为0的产品")]
        public List<Product> Linq2()
        {
            List<Product> list = new List<Product>();
            List<Product> products = data.GetProductList();
            var soldOutProducts =
                from prod in products
                where prod.UnitsInStock == 0
                select prod;
            foreach (var p in soldOutProducts)
            {
                list.Add((Product)p);
            }
            return list;
        }

        [Description("获取价格大于3.00M且库存不为0的产品")]
        public List<Product> Linq3()
        {
            List<Product> list = new List<Product>();
            List<Product> products = data.GetProductList();
            var expensiveInStockProducts =
                from prod in products
                where prod.UnitsInStock > 0 && prod.UnitPrice > 3.00M
                select prod;            
            foreach (var p in expensiveInStockProducts)
            {
                list.Add((Product)p);
            }
            return list;
        }

        [Description("获取华盛顿区域的客户及客户订单")]
        public List<Customer> Linq4()
        {
            List<Customer> list = new List<Customer>();
            List<Customer> customers = data.GetCustomerList();
            var waCustomers =
                from cust in customers
                where cust.Region == "WA"
                select cust;           
            foreach (var customer in waCustomers)
            {
                list.Add((Customer)customer);
            }
            return list;
        }

        [Description("获取数组中【元素长度大于元素索引】的元素")]
        public string Linq5()
        {
            StringBuilder sb = new StringBuilder();
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var shortDigits = digits.Where((digit, index) => digit.Length < index);

            sb.Append("元素长度大于元素索引：");
            foreach (var d in shortDigits)
            {
                sb.Append(d + " ");
            }
            return sb.ToString();
        }
    }
}

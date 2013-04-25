using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace LinqHelper
{
    public class Partitioning
    {
        public DataConstructor data = new DataConstructor();
        [Description("取前5个数据")]
        public string Linq1()
        {
            StringBuilder sb = new StringBuilder();
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numsPlusOne =
                numbers.Take(5);
            sb.Append("取前5个数据：");
            foreach (var x in numsPlusOne)
            {
                sb.Append(x + " ");
            }
            return sb.ToString();
        }
        public List<string> Linq2()
        {
            List<string> list = new List<string>();
            List<Customer> customers = data.GetCustomerList();

            var first3WAOrders =
                (
                    from c in customers
                    from o in c.Orders
                    where c.Region == "WA"
                    select new { c.CustomerID, o.OrderID, o.OrderDate }
                ).Take(3);
            foreach (var x in first3WAOrders)
            {
                list.Add(String.Format("CustomerID={0}, OrderID={1}, OrderDate={2}", x.CustomerID, x.OrderID, x.OrderDate));
            }
            return list;
        }
        public string Linq3()
        {
            StringBuilder sb = new StringBuilder();
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var allButFirst4Numbers = numbers.Skip(3);
            sb.Append("跳过前3数据获得后面的所有数据：");
            foreach (var x in numbers)
            {
                sb.Append(x + " ");

            }
            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
namespace LinqHelper
{
    public class Description
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqHelper
{
    public class Ordering
    {
        public DataConstructor data = new DataConstructor();
        public string Linq1()
        {
            StringBuilder sb = new StringBuilder();
            string[] words = { "cherry", "apple", "blueberry" };
            var sortedWords =
                from w in words
                orderby w
                select w;
            sb.Append("对数组中元素进行排序：");
            foreach (var w in sortedWords)
            {
                sb.Append(w + " ");
            }
            return sb.ToString();
        }

        public object Linq2()
        {
            throw new NotImplementedException();
        }

        public object Linq3()
        {
            throw new NotImplementedException();
        }

        public object Linq4()
        {
            throw new NotImplementedException();
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

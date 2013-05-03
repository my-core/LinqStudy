using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqHelper
{
    public class Conversion 
    {
        public DataConstructor data = new DataConstructor();
        /// <summary>
        /// 对应用程序想缓存查询赋值的结果，
        /// ToArray 这个操作符提供用来强制查询的直接赋值，
        /// 以返回一个含有查询赋值的结果的Array 数组
        /// </summary>
        /// <returns></returns>
        public object Linq1()
        {
            StringBuilder sb = new StringBuilder();
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };
            var sortD =
                from d in doubles
                orderby d descending
                select d;
            var doubleArray = sortD.ToArray();
            sb.Append("返回含有查询赋值的结果的Array 数组:");
            foreach (var d in doubleArray)
            {
                sb.Append(d + " ");
            }
            return sb.ToString();
        }
        /// <summary>
        /// 对应用程序想缓存查询赋值的结果，
        /// ToList 这个操作符提供用来强制查询的直接赋值，
        /// 以返回一个含有查询赋值的结果的List<T> 数组
        /// </summary>
        /// <returns></returns>
        public object Linq2()
        {
            StringBuilder sb = new StringBuilder();
            string[] words = { "cherry", "apple", "blueberry" };
            var sortedWords =
                from w in words
                orderby w
                select w;
            var wordList = sortedWords.ToList();
            sb.Append("返回一个含有查询赋值的结果的List<T>数组:");
            foreach (var w in sortedWords)
            {
                sb.Append(w + "； ");
            }
            return sb.ToString();
        }
        /// <summary>
        /// 将数据集合转换为Dictionary<Name>的键-值集合
        /// </summary>
        /// <returns></returns>
        public object Linq3()
        {
            StringBuilder sb = new StringBuilder();
            var scoreRecords = new[] 
            { 
                new {Name = "Alice", Score = 50},
                new {Name = "Bob"  , Score = 40},
                new {Name = "Cathy", Score = 45}
            };
            var record = scoreRecords.ToDictionary(r => r.Name);
            sb.AppendFormat("Bob's score: {0}", record["Bob"].ToString());
            return sb.ToString();
        }
        /// <summary>
        /// 执行OfType<T>方法将返回集合中强制转换类型成功的所有元素
        /// OfType<T>方法与Cast<T> 方法的区别在于，如果集合中的元素在强制转换失败的时候会跳过，而不是抛出异常。
        /// </summary>
        /// <returns></returns>
        public object Linq4()
        {
            StringBuilder sb = new StringBuilder();
           object[] numbers = { null, 1.0, "two", 3, "four", 5, "six", 7.0 }; 
            var doubles = numbers.OfType<double>();
            sb.Append("执行OfType<double>方法将返回集合中强制转换类型成功的所有元素:");
            foreach (var d in doubles)
            {
                sb.Append(d + " ");
            }
            var strings = numbers.OfType<string>();
            sb.Append("<br/>执行OfType<string>方法将返回集合中强制转换类型成功的所有元素:");
            foreach (var s in strings)
            {
                sb.Append(s + " ");
            }
            return sb.ToString();
        }       
    }
}

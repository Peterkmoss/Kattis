using System.Linq;
using System.Collections.Generic;
using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ");
            var d1 = int.Parse(input[0]);
            var d2 = int.Parse(input[1]);

            var list = new List<int>();

            for (var i = 1 ; i <= d1 ; i++)
            {
                for (var j = 1 ; j <= d2; j++)
                {
                    list.Add(j+i);
                }
            }

            var q = from x in list
                    group x by x into g
                    let count = g.Count()
                    orderby count descending
                    select new {Value = g.Key, Count = g.Count()};
            
            var maxCount = q.First().Count;

            foreach (var x in q)
            {
                if (x.Count == maxCount)
                    Console.WriteLine(x.Value);
            }
        }
    }
}

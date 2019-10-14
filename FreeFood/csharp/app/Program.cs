using System.Collections.Generic;
using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var events = int.Parse(Console.ReadLine());
            var days = new HashSet<int>();
            var latest = 0;
            for (var i = 0; i < events; i++)
            {
                var e = Console.ReadLine().Split(" ");
                var start = int.Parse(e[0]);
                var end = int.Parse(e[1]);

                for (var j = start; j <= end; j++)
                {
                    days.Add(j);
                }
            }
            Console.WriteLine(days.Count);
        }
    }
}
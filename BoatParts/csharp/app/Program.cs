using System.Collections.Generic;
using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ");
            var set = new HashSet<string>();
            for (var i = 0; i < int.Parse(input[1]); i++)
            {
                set.Add(Console.ReadLine());
                if (set.Count == int.Parse(input[0]))
                {
                    Console.WriteLine(i+1);
                    return;
                }
            }
            Console.WriteLine("paradox avoided");
        }
    }
}

using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ");
            var x = int.Parse(input[0]);
            var y = int.Parse(input[1]);
            var n = int.Parse(input[2]);
            for (var i = 1; i <= n ; i++)
            {
                if (i % x != 0 && i % y != 0)
                {
                    Console.WriteLine(i);
                    continue;
                }
                if (i % x == 0)
                    Console.Write("Fizz");
                if (i % y == 0)
                    Console.Write("Buzz");
                Console.WriteLine();                
            }
        }
    }
}

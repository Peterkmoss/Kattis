using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            for (var i = 0 ; i < lines; i++)
            {
                var input = Console.ReadLine().Split(" ");
                var b = double.Parse(input[0]);
                var p = double.Parse(input[1]);
                var abpm = 60.0 / p;
                var abpmb = abpm * b;
                Console.WriteLine((abpmb - abpm) + " " + abpmb + " " + (abpmb + abpm));
            }
        }
    }
}

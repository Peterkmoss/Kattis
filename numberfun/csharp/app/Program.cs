using System;
using static System.Console;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(ReadLine());
            for (var i = 0; i < cases; i++)
            {
                var input = Array.ConvertAll(ReadLine().Split(" "), s => int.Parse(s));
                var a = input[0];
                var b = input[1];
                var c = input[2];
                if (a + b == c
                    || a - b == c
                    || a * b == c
                    || (float)a / (float)b == c
                    || b - a == c
                    || (float)b / (float)a == c)
                    WriteLine("Possible");
                else
                    WriteLine("Impossible");
            }
        }
    }
}

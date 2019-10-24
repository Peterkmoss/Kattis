using System;

namespace janitortroubles
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));
            var a = input[0];
            var b = input[1];
            var c = input[2];
            var d = input[3];

            var lort = (a + b + c + d) / 2;

            Console.WriteLine(Math.Sqrt((lort - a) * (lort - b) * (lort - c) * (lort - d)));
        }
    }
}

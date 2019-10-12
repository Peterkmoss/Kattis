using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(" ");
            var h = int.Parse(line[0]);
            var v = (int.Parse(line[1]) * Math.PI)/180;

            Console.WriteLine(Math.Ceiling(h / Math.Sin(v)));
        }
    }
}

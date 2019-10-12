using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var matches = int.Parse(inputs[0]);
            var w = int.Parse(inputs[1]);
            var h = int.Parse(inputs[2]);
            var x = Math.Sqrt(Math.Pow(h, 2) + Math.Pow(w, 2));

            for (var i = 0; i < matches; i++)
            {
                var l = int.Parse(Console.ReadLine());
                if (l <= x)
                    Console.WriteLine("DA");
                else
                    Console.WriteLine("NE");
            }
        }
    }
}

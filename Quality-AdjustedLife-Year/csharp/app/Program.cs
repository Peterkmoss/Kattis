using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var res = 0.0;
            for (var i = 0; i < lines; i++)
            {
                var vals = Console.ReadLine().Split(" ");
                var q = float.Parse(vals[0]);
                var y = float.Parse(vals[1]);

                res += q * y;
            }
            Console.WriteLine(res);
        }
    }
}

using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var cost = float.Parse(Console.ReadLine());
            var lawns = int.Parse(Console.ReadLine());
            var res = 0.0;
            for (var i = 0 ; i < lawns ; i++)
            {
                var lawn = Console.ReadLine().Split(" ");
                var w = float.Parse(lawn[0]);
                var l = float.Parse(lawn[1]);
                res += w*l*cost;
            }
            Console.WriteLine(res);
        }
    }
}

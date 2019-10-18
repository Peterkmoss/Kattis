using System.Linq;
using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(" ");
            var problems = int.Parse(line[0]);
            var index = int.Parse(line[1]);

            var times = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));

            var pt = 0;
            var ac = 0;
            var t = 0;

            while (t < 300)
            {
                if (times[index] + t <= 300)
                {
                    t += times[index];
                    pt += t;
                    ac++;
                    times[index] = 9999;
                    index = Array.IndexOf(times, times.Min());
                }
                else
                    break;
            }
            Console.WriteLine(ac + " " + pt);
        }
    }
}

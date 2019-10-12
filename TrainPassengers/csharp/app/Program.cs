using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var capacity = int.Parse(input[0]);
            var stations = int.Parse(input[1]);

            var current = 0;
            var possible = true;
            for (var station = 1; station <= stations ; station++)
            {
                var stop = Console.ReadLine().Split(' ');
                var left = int.Parse(stop[0]);
                var entered = int.Parse(stop[1]);
                var wait = int.Parse(stop[2]);

                if (left > current)
                    possible = false;

                current -= left;
                current += entered;
                if (current > capacity) 
                    possible = false;
                if (current < 0)
                    possible = false;
                if (current != capacity && wait > 0)
                    possible = false;
                if (station == stations && current > 0)
                    possible = false;
                if (station == stations && wait > 0)
                    possible = false;
            }
            if (possible)
                Console.WriteLine("possible");
            else
                Console.WriteLine("impossible");
        }
    }
}

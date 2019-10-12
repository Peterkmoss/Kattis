using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            for (var i = 0; i < lines ; i++)
            {
                var input = Console.ReadLine().Split(" ");
                var r = int.Parse(input[0]);
                var e = int.Parse(input[1]);
                var c = int.Parse(input[2]);

                if (e - r > c)
                    Console.WriteLine("advertise");
                else if (e - r == c)
                    Console.WriteLine("does not matter");
                else if (e - r < c)
                    Console.WriteLine("do not advertise");
            }
        }
    }
}

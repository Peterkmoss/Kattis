using System.Linq;
using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = Console.ReadLine().Split(" ");
            var c2 = Console.ReadLine().Split(" ");
            var c3 = Console.ReadLine().Split(" ");
            var c4 = Console.ReadLine().Split(" ");
            var c5 = Console.ReadLine().Split(" ");

            var c1Res = int.Parse(c1[0]) + int.Parse(c1[1]) + int.Parse(c1[2]) + int.Parse(c1[3]);
            var c2Res = int.Parse(c2[0]) + int.Parse(c2[1]) + int.Parse(c2[2]) + int.Parse(c2[3]);
            var c3Res = int.Parse(c3[0]) + int.Parse(c3[1]) + int.Parse(c3[2]) + int.Parse(c3[3]);
            var c4Res = int.Parse(c4[0]) + int.Parse(c4[1]) + int.Parse(c4[2]) + int.Parse(c4[3]);
            var c5Res = int.Parse(c5[0]) + int.Parse(c5[1]) + int.Parse(c5[2]) + int.Parse(c5[3]);

            var max = 0;

            if (c1Res > max)
                max = c1Res;
            if (c2Res > max)
                max = c2Res;
            if (c3Res > max)
                max = c3Res;
            if (c4Res > max)
                max = c4Res;
            if (c5Res > max)
                max = c5Res;

            if (max == c1Res)
                Console.WriteLine("1 " + c1Res);
            else if (max == c2Res)
                Console.WriteLine("2 " + c2Res);
            else if (max == c3Res)
                Console.WriteLine("3 " + c3Res);
            else if (max == c4Res)
                Console.WriteLine("4 " + c4Res);
            else if (max == c5Res)
                Console.WriteLine("5 " + c5Res);
        }
    }
}

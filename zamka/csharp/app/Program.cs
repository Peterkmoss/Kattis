using System;
using static System.Console;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var L = int.Parse(ReadLine());
            var D = int.Parse(ReadLine());
            var X = int.Parse(ReadLine());

            for (var n = L; n <= D; n++)
            {
                if (findNumber(n, X) != 0)
                {
                    WriteLine(n);
                    break;
                }
            }
            for (var m = D; m >= L; m--)
            {
                if (findNumber(m, X) != 0)
                {
                    WriteLine(m);
                    break;
                }
            }
        }

        private static int findNumber(int i, int x)
        {
            var iString = i.ToString();
            var number = 0;
            foreach (var c in iString)
                number += int.Parse(c.ToString());
            if (number == x)
                return number;
            else
                return 0;
        }
    }
}

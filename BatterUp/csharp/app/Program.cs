using System;
using static System.Console;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadLine();
            var input = Array.ConvertAll(ReadLine().Split(" "), s => int.Parse(s));
            var res = 0.0;
            var count = 0;
            foreach (var i in input)
            {
                if (i >= 0)
                {
                    res += i;
                    count++;
                }
            }
            res /= count;
            WriteLine(res);
        }
    }
}

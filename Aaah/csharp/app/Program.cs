using System.Linq;
using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var max = Console.ReadLine().Where(c => c == 'a').Count();
            if (Console.ReadLine().Where(c => c == 'a').Count() > max)
                Console.WriteLine("no");
            else
                Console.WriteLine("go");

        }
    }
}

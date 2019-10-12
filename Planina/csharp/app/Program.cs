using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var iterations = int.Parse(Console.ReadLine());
            var i = 2;
            while (iterations > 0)
            {
                i += i - 1;
                iterations--;
            }
            var result = Math.Pow(i, 2);
            Console.WriteLine(result);
        }
    }
}

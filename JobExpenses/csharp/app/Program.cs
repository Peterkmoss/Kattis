using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var res = 0;
            var numbers = Console.ReadLine().Split(" ");
            for (var i = 0; i < n; i++)
            {
                var number = int.Parse(numbers[i]);
                if (number < 0)
                    res += Math.Abs(number);
            }
            Console.WriteLine(res);
        }
    }
}

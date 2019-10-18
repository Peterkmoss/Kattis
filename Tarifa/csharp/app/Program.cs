using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var mbMontly = int.Parse(Console.ReadLine());
            var months = int.Parse(Console.ReadLine());
            var res = mbMontly;
            for (var i = 0; i < months; i++)
            {
                var used = int.Parse(Console.ReadLine());
                res += mbMontly - used;
            }
            Console.WriteLine(res);
        }
    }
}

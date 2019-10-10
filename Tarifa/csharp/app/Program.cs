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
            for (var i = 0; i < months ; i++)
            {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line)) break;
                var used = int.Parse(line);
                res += mbMontly-used;
            }
            Console.WriteLine(res);
        }
    }
}

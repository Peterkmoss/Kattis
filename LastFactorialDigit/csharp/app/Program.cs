using System.Linq;
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
                var input = int.Parse(Console.ReadLine());
                var res = 1;
                for (var j = input ; j > 1; j--)
                {
                    res *= j;
                }
                Console.WriteLine(res.ToString().Last());
            }
        }
    }
}

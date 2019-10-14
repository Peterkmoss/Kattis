using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split("-");
            var res = "";
            foreach (var s in input)
            {
                res += s[0];
            }
            Console.WriteLine(res);
        }
    }
}

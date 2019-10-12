using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());
            for (var i = 0; i < cases; i++)
            {
                var first = Console.ReadLine();
                var second = Console.ReadLine();

                Console.WriteLine(first);
                Console.WriteLine(second);

                for (var j = 0; j < first.Length; j++)
                {
                    if (first[j] == second[j])
                        Console.Write(".");
                    else
                        Console.Write("*");
                }

                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}

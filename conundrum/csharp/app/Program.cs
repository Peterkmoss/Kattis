using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var days = 0;
            for (var i = 0; i < input.Length; i += 3)
            {
                if (input[i] != 'P') days++;
                if (input[i + 1] != 'E') days++;
                if (input[i + 2] != 'R') days++;
            }
            Console.WriteLine(days);
        }
    }
}

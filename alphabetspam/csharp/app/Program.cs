using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var lower = 0;
            var upper = 0;
            var whites = 0;
            var symbols = 0;

            foreach (var c in input)
            {
                if (char.IsLower(c)) lower++;
                else if (char.IsUpper(c)) upper++;
                else if (c == '_') whites++;
                else symbols++;
            }

            Console.WriteLine((double)whites / input.Length);
            Console.WriteLine((double)lower / input.Length);
            Console.WriteLine((double)upper / input.Length);
            Console.WriteLine((double)symbols / input.Length);
        }
    }
}

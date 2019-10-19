using System;
using static System.Console;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = ReadLine();
            var result = "";
            char last = ' ';

            foreach (var c in input)
            {
                if (c != last)
                {
                    result += c;
                    last = c;
                }
            }
            WriteLine(result);
        }
    }
}

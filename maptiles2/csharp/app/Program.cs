using System.Linq;
using System;
using static System.Console;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = ReadLine();
            var zoom = input.Length;
            var x = 0;
            var y = 0;

            for (var i = 0; i < input.Length; i++)
            {
                var c = input[zoom - i - 1];
                var increase = (int)Math.Pow(2, i + 1) / 2;
                if (c == '1') x += increase;
                else if (c == '2') y += increase;
                else if (c == '3')
                {
                    x += increase;
                    y += increase;
                }
            }

            WriteLine($"{zoom} {x} {y}");
        }
    }
}

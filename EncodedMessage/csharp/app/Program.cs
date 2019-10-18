using System;
using static System.Console;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(ReadLine());
            for (var i = 0; i < cases; i++)
            {
                var input = ReadLine().ToCharArray();
                var size = (int)Math.Sqrt(input.Length);
                for (var j = size - 1; j >= 0; j--)
                {
                    for (var k = j; k < input.Length; k += size)
                        Write(input[k]);
                }
                WriteLine();
            }
        }
    }
}

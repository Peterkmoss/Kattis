using System;
using static System.Console;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Array.ConvertAll(ReadLine().Split(" "), s => float.Parse(s));
            if (Math.Pow(input[1] / (2 * Math.PI), 2) * Math.PI >= input[0])
                WriteLine("Diablo is happy!");
            else
                WriteLine("Need more materials!");
        }
    }
}

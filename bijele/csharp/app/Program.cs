using System;
using static System.Console;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Array.ConvertAll(ReadLine().Split(" "), s => int.Parse(s));
            Write(1 - input[0] + " ");
            Write(1 - input[1] + " ");
            Write(2 - input[2] + " ");
            Write(2 - input[3] + " ");
            Write(2 - input[4] + " ");
            Write(8 - input[5]);
        }
    }
}

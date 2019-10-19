using System;
using static System.Console;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Array.ConvertAll(ReadLine().Split(" "), s => int.Parse(s));
            var date = new DateTime(2009, input[1], input[0]);
            WriteLine(date.DayOfWeek);
        }
    }
}

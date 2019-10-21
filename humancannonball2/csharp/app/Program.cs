using System;
using static System.Console;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCases = int.Parse(ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                var input = Array.ConvertAll(ReadLine().Split(" "), s => float.Parse(s));
                var v_0 = input[0];
                var angle = Math.PI * input[1] / 180.0;
                var x_1 = input[2];
                var h_1 = input[3];
                var h_2 = input[4];

                var time = x_1 / (v_0 * Math.Cos(angle));
                var y = v_0 * time * Math.Sin(angle) - (0.5 * 9.81 * Math.Pow(time, 2));
                if (y > h_1 + 1 && y < h_2 - 1) WriteLine("Safe");
                else WriteLine("Not Safe");

            }
        }
    }
}

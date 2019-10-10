using System;
using System.Collections.Generic;
using System.Linq;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCases = int.Parse(Console.ReadLine());
            for (var i = 0 ; i < testCases ; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var number = input[0];
                var from = input[1];
                var to = input[2];

                Console.WriteLine($"Case #{i}: " + IntToBase(BaseToInt(number, from), to));
            }
        }

        static int BaseToInt(string number, string from) {
            var resInt = 0;
            var pointer = 0;
            var m = from.ToCharArray();
            for (var i = 0 ; i < number.Length ; i++)
            {
                resInt += m[i] * (int)Math.Pow(from.Length, pointer++);
            }
            return resInt;
        }

        static string IntToBase(int number, string to) {
            var list = new char[200];
            var l = to.Length;
            var m = to.ToCharArray();
            while (number > 0)
            {
                list = new char[m[number % l]].Concat(list).ToArray();
                number /= l;
            }
            return new String(list);
        }
    }
}

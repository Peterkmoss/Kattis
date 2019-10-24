using System;
using static System.Console;

namespace pot
{
    class Program
    {
        static void Main(string[] args)
        {
            var tests = int.Parse(ReadLine());
            var result = 0.0;
            for (int i = 0; i < tests; i++)
            {
                var input = ReadLine();
                var arr = input.ToCharArray();
                var pow = int.Parse(arr[arr.Length - 1].ToString());
                var str = "";
                for (int j = 0; j < arr.Length - 1; j++)
                    str += arr[j];
                var num = int.Parse(str);
                result += Math.Pow(num, pow);

            }
            WriteLine(result);
        }
    }
}

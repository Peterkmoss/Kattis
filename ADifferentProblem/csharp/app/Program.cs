using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var line = Console.ReadLine();
                if (!string.IsNullOrEmpty(line))
                {
                    var numbers = line.Split(" ");
                    Console.WriteLine(Math.Abs(long.Parse(numbers[0]) - long.Parse(numbers[1])));
                }
                else
                    break;
            }
        }
    }
}

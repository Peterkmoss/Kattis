using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            for (var i = 0; i < lines; i++)
            {
                var number = int.Parse(Console.ReadLine());
                Console.WriteLine(number + (number % 2 == 0 ? " is even" : " is odd"));
            }
        }
    }
}

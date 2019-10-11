using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var stones = int.Parse(Console.ReadLine());
            if (stones % 2 == 0)
                Console.WriteLine("Bob");
            else
                Console.WriteLine("Alice");
        }
    }
}

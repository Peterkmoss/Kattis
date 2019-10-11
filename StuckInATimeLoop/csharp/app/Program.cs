using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            for (var i = 1; i <= lines; i++)
            {
                Console.WriteLine(i + " Abracadabra");
            }
        }
    }
}

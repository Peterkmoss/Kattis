using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(" ");
            var hours = int.Parse(line[0]);
            var minutes = int.Parse(line[1]);

            if (minutes - 45 < 0)
            {
                minutes += 15;
                if (hours - 1 < 0)
                    hours = 24;
                hours--;
            }
            else
                minutes -= 45;

            Console.WriteLine(hours + " " + minutes);
        }
    }
}

using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ");
            var x = int.Parse(input[0]);
            var y = int.Parse(input[1]);
            var z = int.Parse(input[2]);

            if (x + y == z)
                Console.WriteLine(x + "+" + y + "=" + z);
            else if (x - y == z)
                Console.WriteLine(x + "-" + y + "=" + z);
            else if (x / y == z)
                Console.WriteLine(x + "/" + y + "=" + z);
            else if (x * y == z)
                Console.WriteLine(x + "*" + y + "=" + z);
            else if (x == y + z)
                Console.WriteLine(x + "=" + y + "+" + z);
            else if (x == y - z)
                Console.WriteLine(x + "=" + y + "-" + z);
            else if (x == y / z)
                Console.WriteLine(x + "=" + y + "/" + z);
            else if (x == y * z)
                Console.WriteLine(x + "=" + y + "*" + z);
        }
    }
}

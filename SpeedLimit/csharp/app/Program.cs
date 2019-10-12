using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = int.Parse(Console.ReadLine());
                if (input == -1)
                    break;
                var res = 0;
                var lastTime = 0;
                for (var i = 1; i <= input; i++)
                {
                    var line = Console.ReadLine().Split(" ");
                    var speed = int.Parse(line[0]);
                    var currentTime = int.Parse(line[1]);
                    res += speed * (currentTime - lastTime);
                    lastTime = currentTime;
                }
                Console.WriteLine(res + " miles");
            }
        }
    }
}
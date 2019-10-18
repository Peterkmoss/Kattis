using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var ball = 1;

            foreach (var c in input)
            {
                switch (ball)
                {
                    case 1:
                        if (c == 'A')
                            ball = 2;
                        if (c == 'C')
                            ball = 3;
                        break;
                    case 2:
                        if (c == 'A')
                            ball = 1; 
                        if (c == 'B')
                            ball = 3;
                        break;
                    case 3:
                        if (c == 'B')
                            ball = 2;
                        if (c == 'C')
                            ball = 1;
                        break;
                }
            }

            Console.WriteLine(ball);
        }
    }
}

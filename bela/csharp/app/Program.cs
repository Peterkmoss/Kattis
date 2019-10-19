using System;
using static System.Console;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var i1 = ReadLine().Split(" ");
            var n = i1[0];
            var s = i1[1];

            var res = 0;

            for (var i = 0; i < int.Parse(n) * 4; i++)
            {
                var card = ReadLine();
                switch (card[0])
                {
                    case 'A':
                        res += 11;
                        break;
                    case 'K':
                        res += 4;
                        break;
                    case 'Q':
                        res += 3;
                        break;
                    case 'J':
                        if (card.Contains(s)) res += 20;
                        else res += 2;
                        break;
                    case 'T':
                        res += 10;
                        break;
                    case '9':
                        if (card.Contains(s))
                            res += 14;
                        break;
                    default:
                        break;
                }
            }
            WriteLine(res);
        }
    }
}

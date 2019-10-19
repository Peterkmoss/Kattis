using System.Linq;
using System;
using static System.Console;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var read = ReadLine().Split(" ");
                if (read[0] == "0")
                    return;

                var shift = int.Parse(read[0]);
                var input = read[1].Reverse().ToArray();

                for (var i = 0; i < input.Length; i++)
                {
                    if (input[i] == '.')
                    {
                        if (shift != 27)
                        {
                            input[i] = 'A';
                            input[i] += (char)(shift - 1);
                        }
                        else
                            input[i] = '_';
                    }
                    else if (input[i] == '_')
                    {
                        if (shift == 1)
                            input[i] = '.';
                        else
                        {
                            input[i] = 'A';
                            input[i] += (char)(shift - 2);
                        }
                    }
                    else
                    {
                        input[i] += (char)shift;
                        if (input[i] == 'Z' + 1)
                            input[i] = '_';
                        else if (input[i] == 'Z' + 2)
                            input[i] = '.';
                        else if (input[i] > 'Z' + 2)
                            input[i] -= (char)28;
                    }
                }
                WriteLine(input);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace app
{
    class Program
    {

        private static IDictionary<string, string> dictionary = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            var testCases = int.Parse(Console.ReadLine());
            for (var i = 0; i < testCases; i++)
            {
                parseMenu(dictionary);

                Console.WriteLine();
            }
        }

        static void parseMenu(IDictionary<string, string> dictionary)
        {
            var pizzas = int.Parse(Console.ReadLine());
            for (var i = 0; i < pizzas; i++)
            {
                parsePizza(dictionary);
            }
        }

        static void parsePizza(IDictionary<string, string> dictionary)
        {
            var pizza = Console.ReadLine();
            var native = Console.ReadLine().Split(" ");
            var english = Console.ReadLine().Split(" ");

            for (var i = 1; i <= Math.Max(int.Parse(native[0]), int.Parse(native[0])); i++)
            {
                if (i <= english.Length)
                {
                    dictionary.Add(pizza, english[i]);
                }
                if (i <= native.Length)
                {
                    dictionary.Add(pizza, native[i]);
                }
            }
        }
    }
}

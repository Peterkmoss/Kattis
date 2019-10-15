using System;
using System.Collections.Generic;
using System.Linq;

namespace app
{
    class Program
    {

        private static IDictionary<string, string> nDictionary = new Dictionary<string, string>();
        private static IDictionary<string, string> eDictionary = new Dictionary<string, string>();
        private static IList<string> nList = new List<string>();
        private static IList<string> eList = new List<string>();

        static void Main(string[] args)
        {
            var testCases = int.Parse(Console.ReadLine());
            for (var i = 0; i < testCases; i++)
            {
                parseMenu();

                nList = nList.OrderBy(i => i).ToList();
                eList = eList.OrderBy(i => i).ToList();

                Console.WriteLine();
            }
        }

        static void parseMenu()
        {
            var pizzas = int.Parse(Console.ReadLine());
            for (var i = 0; i < pizzas; i++)
            {
                var pizza = Console.ReadLine();
                var native = Console.ReadLine().Split(" ");
                var english = Console.ReadLine().Split(" ");
                for (var j = 1; j <= native.Length; j++)
                {
                    var ingr = native[j];
                    if (!nList.Contains(ingr))
                        nList.Add(ingr);
                    nDictionary.Add(ingr, nDictionary[ingr] ?? "" + pizza);
                }
                for (var j = 1; j <= english.Length; j++)
                {
                    var ingr = english[j];
                    if (!eList.Contains(ingr))
                        eList.Add(ingr);
                    eDictionary.Add(ingr, eDictionary[ingr] ?? "" + pizza);
                }
            }
        }
    }
}

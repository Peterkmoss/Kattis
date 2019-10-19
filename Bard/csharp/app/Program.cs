using System.Collections.Generic;
using System.Linq;
using System;
using static System.Console;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var villagers = int.Parse(ReadLine());
            var nights = int.Parse(ReadLine());

            var knows = new Dictionary<int, HashSet<int>>();
            var bardSongs = 0;
            for (var i = 1; i <= villagers; i++)
                knows.Add(i, new HashSet<int>());

            for (var i = 0; i < nights; i++)
            {
                var share = false;
                var line = Array.ConvertAll(ReadLine().Split(" "), s => int.Parse(s));
                line = line.Skip(1).ToArray();
                if (!line.Contains(1))
                    share = true;
                if (!share)
                {
                    bardSongs++;
                    foreach (var n in line)
                        knows[n].Add(bardSongs);
                }
                else
                {
                    var allSongs = new HashSet<int>();
                    foreach (var n in line)
                        allSongs.UnionWith(knows[n]);
                    foreach (var n in line)
                        knows[n].UnionWith(allSongs);
                }
            }
            var max = knows[1].Count;
            for (var i = 1; i <= villagers; i++)
                if (knows[i].Count == max)
                    WriteLine(i);
        }
    }
}

using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
           var line = Console.ReadLine();
           var numbers = line.Split(' ');
           var articles = int.Parse(numbers[0]);
           var impact = int.Parse(numbers[1]);

           Console.WriteLine((articles * (impact-1))+1);
        }
    }
}

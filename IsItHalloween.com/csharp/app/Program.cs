using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input == "OCT 31" || input == "DEC 25")
                Console.WriteLine("yup");
            else 
                Console.WriteLine("nope");
        }
    }
}

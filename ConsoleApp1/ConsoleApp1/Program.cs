using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            var s = "SELECT * FROM {0}";
            var x = Console.ReadLine();
            Console.WriteLine(String.Format(s, x));
        }
    }
}

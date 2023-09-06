using System;

namespace Uppgift1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine(":(");
            Console.WriteLine("Your PC ran into a problem and needs to restart. We´re just");
            Console.WriteLine("collecting some error info, and then we we´ll restart for you. (0%");
            Console.WriteLine("complete)");
            Console.WriteLine("If you would like to know morem you can search online for this error");
            Console.ReadKey();
        }
    }
}
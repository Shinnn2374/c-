using System;

namespace letsStart
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write your name:");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
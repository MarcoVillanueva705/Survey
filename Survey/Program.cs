using System;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();

            Console.WriteLine($"Your name is: { name }");
            Console.WriteLine($"Your age is { age }");
        }
    }
}

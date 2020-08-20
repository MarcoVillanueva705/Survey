using System;

namespace Survey
{
    class Program
    {
        //adding functions to exercise tomorrow
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            if (name == "")
            {
                writeTryAgain();
            }

            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();

            if (age == "")
            {
                writeTryAgain();
            }

            Console.WriteLine("What month were you born in?");
            var month = Console.ReadLine();

            if (month == "")
            {
                writeTryAgain();
            }

            Console.WriteLine($"Your name is: { name }");
            Console.WriteLine($"Your age is { age }");
            Console.WriteLine($"Your month is { month }");
        }
        static void writeTryAgain()
        {
            Console.WriteLine("You can't leave field blank!");
        }
    }
}

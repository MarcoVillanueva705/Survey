using System;

namespace Survey
{
    class Program
    {
        //adding functions to exercise tomorrow
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            //WriteTryAgain()
            var name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();

            Console.WriteLine("What month were you born in?");
            var month = Console.ReadLine();

            Console.WriteLine($"Your name is: { name }");
            Console.WriteLine($"Your age is { age }");

            if (month == "March")
            {
                Console.WriteLine("You are an Aries!");
            }
        }
    }
}

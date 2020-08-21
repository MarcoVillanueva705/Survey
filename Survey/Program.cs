using System;

namespace Survey
{
    class Program
    {
        //adding functions to exercise tomorrow
        static void Main(string[] args)
        {
            var name = "";
            var age = "";
            var month = "";
            //attempt DRY

            while (name == "") { 

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();


            if (name == "")
            {
                writeTryAgain();
            }
        }
            while (age == "") { 
            

                Console.WriteLine("What is your age?");
                age = Console.ReadLine();


                if (age == "")
                {
                    writeTryAgain();
                }
            }
            while (month == "")
            {

                Console.WriteLine("What month were you born in?");
                month = Console.ReadLine();


                if (month == "")
                {
                    writeTryAgain();
                }
            }
            

            Console.WriteLine($"Your name is: { name }");
            Console.WriteLine($"Your age is { age }");
            Console.WriteLine($"You were born in { month }");
        }
        static void writeTryAgain()
        {
            Console.WriteLine("You can't leave field blank!");
        }
    }
}

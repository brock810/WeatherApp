using System;

namespace MethodsExercise
{

    class program
    {
        static void Main(string[] args)
        {
           // Name = "Brock";

           // color = "Blue";

           // drink = "Whiskey";
           
           // animal = "cats";
           

            Console.WriteLine("What is your name?"); // output
            var userName = Console.ReadLine(); // input

            Console.WriteLine($"Hi {userName} What is your favorite color?");
            var color = Console.ReadLine(); // input

            Console.WriteLine($"{color} is an awesome color! What is your favorite drink?"); // output
            var drink = Console.ReadLine(); // input

            Console.WriteLine($"Whiskey! good choice!");
            


        }


    }

}


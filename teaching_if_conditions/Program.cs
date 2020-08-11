using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace teaching_if_conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise1
            EvenOrOdd();

            // Exercise2
            FizzBuzz();

            // Exercise3
            BecomeFriends();

            // Exercise4
            AreYouYonatan();
        }


        /// <summary>
        /// Receives a number from the user and prints Even! if it's even
        /// and Odd! if it's odd
        /// </summary>
        static void EvenOrOdd()
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                // Division of number by 2 has no remainder, so it is even
                Console.WriteLine("Even!");
            }
            else
            {
                // The number is not even, so it can only be odd
                Console.WriteLine("Odd!");
            }
        }

        /// <summary>
        /// Receives a number from the user
        /// prints Fizz if it's a multiple of 3
        /// prints Buzz if it's a multiple of 5
        /// prints FizzBuzz if it's a multiple of 3 and 5
        /// Only prints a SINGLE message
        /// </summary>
        static void FizzBuzz()
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            if (number % 3 == 0 && number % 5 == 0)
            {
                // Number fulfils both conditions, so we need to print FizzBuzz
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 5 == 0)
            {
                // Number fulfils only condition for Fizz
                Console.WriteLine("Fizz");
            }
            else if (number % 3 == 0)
            {
                // Number fulfils only condition for Buzz
                Console.WriteLine("Buzz");
            }
        }

        /// <summary>
        /// Asks the user for his name and prints the correct message
        /// </summary>
        static void BecomeFriends()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                // There was no name provided, need to ask user again
                Console.WriteLine("Please enter your name (last chance)");
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Ok, I won't invite you for ice cream");
                }
                else
                {
                    Console.WriteLine("Let's go eat a burger!");
                }
            }
            else
            {
                Console.WriteLine("We're best friends now!");
            }
        }

        /// <summary>
        /// Asks the user for his name and prints the correct message
        /// </summary>
        static void AreYouYonatan()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            if (name.ToLower() == "yonatan")
            {
                Console.WriteLine("I like your name!");
            }
            else
            {
                Console.WriteLine("That's an awesome name!");
            }
        }
    }
}

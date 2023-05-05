using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Threading;

namespace Loops__Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Five Hellos
            // Write a for loop that will run five times and write “hello!” to the console five times:

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hello");
            }


            // Task 2: Counting
            // Write a for loop that counts from 0 to 10, with each number being written to the console one at a time

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
            }


            // Task 3: Counting Backwards
            // Write a for loop that counts from 10 to 0, with each
            // number being written to the console one at a time.
            // HINT: When using for loop, provide three arguments 
            // “for (start, condition, iterator)”
                 // start   condition iterator
            for (int i = 10;  i >= 0;   i--)
            {
                Console.WriteLine(i);
            }


            // Task 4: Prompted Output
            // Write a for loop that will run as many times as a 
            // user wants, with each iteration printing 
            // “devCodeCamp” to the console. HINT: you will 
            // need to use the C# Console.ReadLine() function
            // to gather user input for how many times the user would like the loop to run!

            Console.WriteLine("How many time do you want to print 'devCodeCamp' to the console?");
            int userRequest = int.Parse(Console.ReadLine());
            for (int i = 0; i < userRequest; i++)
            {
                Console.WriteLine("devCodeCamp");
            }


            // Task 5: Packers Split-Up
            // Write a for loop that will write each character of the string “Packers” to the console. 

            string teamName = "Packers";
            for (int i = 0; i < teamName.Length; i++)
            {
                Console.WriteLine(teamName[i]);
            }


            // Task 6: CHALLENGE - Fizz Buzz
            // 1. Write a program that writes every number from 0 to 100 to the console
            // 2. If a number is divisible by 3, write ‘fizz’ instead of the number
            // 3. If a number is divisible by 5, write ‘buzz’ instead of the number
            // 4. If a number is divisible by 3 and 5, write ‘fizzbuzz’ instead of the number

            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }


            // Task 7: Five Hellos (again)
            // Write a while loop that will run five times and write “hello!” to the console five times

            int count = 0;
            while (count < 5)
            {
                Console.WriteLine("hello!");
                count++;
            }


            // Task 8: Validation 
            // Write a while loop that will prompt a user for
            // their password and will continue to prompt the
            // user until the typed in password is correct. If
            // correct, write to the console “User Validated”

            
            string userPassword = "";
            while (userPassword != "password123")
            {
                Console.WriteLine("What is the password?");
                userPassword = Console.ReadLine();
            }

            Console.WriteLine("User Validated");

        }
    }
}
using System;
using System.ComponentModel;

namespace Conditionals_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Driving Age
            // Declare a variable and assign it the value of the legal driving age in the United States.

            // Declare a variable to store a user's age. Use the built-in Console.ReadLine()
            // function to retrieve the user’s age via user input.

            // If the user’s age is greater than or equal to the legal driving age in the United
            // States, then write to the console “You are legally able to drive.”

            // If the user’s age is less than the legal driving age in the United States, write to
            // the console “You are not old enough to drive yet.”

            int drivingAge = 17;
            Console.WriteLine("How old are you?");
            int usersAge = int.Parse(Console.ReadLine());

            if (usersAge >= drivingAge)
            {
                Console.WriteLine("You are legally able to drive.");
            }
            else
            {
                Console.WriteLine("You are not old enough to drive yet.");
            }


            // Task 2: Random Number
            // Declare a variable to store a random number between 0 and 10. You will need
            // to do some research to determine how to generate a random number in C#.
            //A good search term to use: “random number C#”
            // If the number is between 0 and 2, write to the console “0 or 1 or 2”
            // If the number is between 3 and 5, write to the console “3 or 4 or 5”
            // If the number is between 6 and 8, write to the console “6 or 7 or 8”
            // If the number is equal to 9 or 10, write to the console “9 or 10”

            Random random = new Random();
            int randomNumber = random.Next(0, 11);
            Console.WriteLine(randomNumber);

            if (randomNumber >= 0 && randomNumber <= 2)
            {
                Console.WriteLine("0 or 1 or 2");
            }
            else if (randomNumber >= 3 && randomNumber <= 5)
            {
                Console.WriteLine("3 or 4 or 5");
            }
            else if (randomNumber >= 6 && randomNumber <= 8)
            {
                Console.WriteLine("6 or 7 or 8");
            }
            else
            {
                Console.WriteLine("9 or 10");
            }


            // Task 3: NFL Teams
            // Declare a variable to store an NFL team name. Use the built-in
            // Console.ReadLine() function to retrieve a user’s inputted favorite NFL team.

            // Build out a conditional for “Bears”, in which if selected it will write to the
            // console “Quarterback much?”

            // Build out a conditional for “Vikings”, in which if selected it will write to the
            // console “Loud noises!”

            // Build out a conditional for “Lions”, in which if selected it will write to the
            // console “LOL! They bad!” 

            // Build out a conditional for “Packers” in which if selected it will write to the
            // console “Best team in the world!Actually, the universe!” 

            // Build out a “default” conditional to write to the console “Pick a different
            // team” in the scenario where a user doesn’t input “Bears”, “Vikings”, “Lions”, or “Packers”.

            string favoriteTeam;
            Console.WriteLine("Enter your favorite NFL team: ");
            favoriteTeam = Console.ReadLine();

            if (favoriteTeam == "Bears")
            {
                Console.WriteLine("Quarterback much?");
            }
            else if (favoriteTeam == "Vikings")
            {
                Console.WriteLine("Loud noises!");
            }
            else if (favoriteTeam == "Lions")
            {
                Console.WriteLine("LOL! They bad!");
            }
            else if (favoriteTeam == "Packers")
            {
                Console.WriteLine("Best team in the world! Actually, the universe!");
            }
            else
            {
                Console.WriteLine("Pick a different team.");
            }

        }
    }
}
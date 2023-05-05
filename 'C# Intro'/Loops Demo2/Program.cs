namespace Loops_Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While Loop
            int myNumber = 0;
            while (myNumber < 10)
            {
                Console.WriteLine(myNumber);
                myNumber++;
            }

            string myUsername = "josepho";
            string myPassword = "password123";

            int numberOfAttempts = 0;
            while (numberOfAttempts < 3)
            {
                Console.WriteLine("Number of login attempts: " + numberOfAttempts);

                Console.WriteLine("What is your username?");
                string usernameInput = Console.ReadLine();

                Console.WriteLine("What is your password?");
                string passwordInput = Console.ReadLine();

                if (usernameInput == myUsername && passwordInput == myPassword)
                {
                    Console.WriteLine("Login Successful!");
                    break;
                }
                else if (usernameInput == myUsername && passwordInput != myPassword)
                {
                    Console.WriteLine("Incorrect Password");
                }
                else
                {
                    Console.WriteLine("No users found with those credentials");
                }
                numberOfAttempts++;

            }

            //For loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("The value of i is " + i);
            }

            //Foreach loop
            string[] players = { "Devin Hester", "Brian Urlacher", "Brett Favre", "Walter Payton", "Justin Fields" };
            foreach (string player in players)
            {
                if(player == "Brett Favre")
                {
                    Console.WriteLine("Lets just skipp that player");
                    continue;
                }
                Console.WriteLine("Name: " + player);
            }
        }
    }
}
namespace Loops_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LOOPS Examples
            // while Loop

            int age = 10;
            bool cannotDrive = true;

            while (cannotDrive == true)
            {
                if (age == 16)
                {
                    cannotDrive = false;
                    Console.WriteLine(" I can Drive!");
                }
                else
                {
                    Console.WriteLine("Can't drive yet!");
                    age++;
                }

                //Do-While Loop
                double input;
                do
                {
                    Console.WriteLine("Enter a positive number:\n");
                    input = double.Parse(Console.ReadLine());
                } while (input <= 0);

                // For Loop
                // for (int i = 0; i < 10; i++)
                //{
                //    // Code to execute
                //    // This loo[ will run 10 times!
                //}
                string greeting = "Hello!";
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine($"{greeting} Value of i: {i}");
                }

                // Break Example:
                for (int i = 0; i < 5; i++)
                {
                    if (i == 2)
                    {
                        Console.WriteLine("Breaking loop");
                        break;
                    }
                    Console.WriteLine(i);
                }

                // Continue Example:
                for (int i = 0; i < 5; i++)
                {
                    if (i == 2)
                    {
                        Console.WriteLine("Skipping to next.");
                        continue;
                    }
                    Console.WriteLine(i);
                }


            }
        }
    }
}
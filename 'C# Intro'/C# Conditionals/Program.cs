namespace C__Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Comparison Operators
            int x = 5;
            int y = 7;

            // == Equal to
            Console.WriteLine(x == y); // output: False

            // != Not equal to
            Console.WriteLine(y != x); // output: True

            // < Less than
            Console.WriteLine(x < y); // output: True
            Console.WriteLine(y < x); // output: False

            // > Greater than
            Console.WriteLine(y > x); // output: True

            // <= Less than or equal to
            // >= Greater than or equal to
            Console.WriteLine(y <= y); // output: True
            Console.WriteLine(y>= x); // output: True


            // && (and) operator
            // - if ALL Expressions are True, the ENTIRE expression is True
            // - if ANY Expressions is False, the ENTIRE expression is False
            int age = 17;
            bool hasDriversLicense = false;
            bool isWithParent = true;

            bool isTeenager = age >= 13 && age <= 19;
            Console.WriteLine(isTeenager); // output: True

            bool canDrive = age >= 16 && hasDriversLicense;
            Console.WriteLine(canDrive); // output: False


            // || (or) operator
            // If ANY Expressions are True, the ENTIRE expression is TRUE
            // If ALL Expressions are FALSE, the ENTIRE expression is FALSE
            bool allowedToDrive = hasDriversLicense || isWithParent;
            Console.WriteLine(allowedToDrive); // output: True


            // ! (negation) operator
            // Returns the OPPOSITE when used on Booleans
            bool valid = false;
            Console.WriteLine(valid); // output: False

            valid = !valid;
            Console.WriteLine(valid); // output: True
            Console.WriteLine(!valid); // output: False

            // Conditionals 
            // Allows code to execute ONLY when some condition is True

            //"if" statements
            int favorite_number = 16;
            int user_input = 24;

            if (favorite_number == user_input)
            {
                Console.WriteLine(" Nice! You found my favorite number!");
            }
            else if(favorite_number < user_input)
            {
                Console.WriteLine("That's higher than my number!");
            }
            else if(favorite_number > user_input)
            {
                Console.WriteLine("That's lower than my favorite number..");
            }
            else
            {
                Console.WriteLine("User input out of range..");
            }


            //"if" statement demo 2
            string myUsername = "josepho";
            string myPassword = "password123";

            Console.WriteLine(" What is your username?");
            string usernameInput = Console.ReadLine();

            Console.WriteLine("What is your password?");
            string passwordInput = Console.ReadLine();

            if (usernameInput == myUsername && passwordInput == myPassword)
            {
                Console.WriteLine("Login Successful!");
            }
            else if (usernameInput == myUsername && passwordInput != myPassword)
            {
                Console.WriteLine("Incorrect Password!");
            }
            else if (usernameInput != myUsername && passwordInput == myPassword)
            {
                Console.WriteLine("Incorrect Username!");
            }
            else
            {
                Console.WriteLine("No user found..");
            }


            // "switch" case
            Console.WriteLine("Who invented AC electricity?");
            string acInventorInput = Console.ReadLine();

            switch(acInventorInput)
            {
                case "Albert Einstein":
                    Console.WriteLine("Not quite!");
                    break;
                case "Nikola Tesla":
                    Console.WriteLine("Correct!");
                    break;
                case "Mr. Alternating Current":
                    Console.WriteLine("Nope!");
                    break;
                default:
                    {
                    Console.WriteLine("Incorrect...");
                    break;
                    }
            }




        }
    }
}
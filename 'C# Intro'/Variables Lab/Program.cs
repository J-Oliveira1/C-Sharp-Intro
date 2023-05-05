namespace Variables_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 33;
            Console.WriteLine($"I am {age} years old.");

            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();

            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            Console.WriteLine($"My first name is {firstName} and my last name is {lastName}, which means my full name is {fullName}.");

            double fahrenheitTemp = 93;
            double celsiusTemp = (fahrenheitTemp - 32) * 5 / 9;
            Console.WriteLine($"{fahrenheitTemp} degrees Fahrenheit is {celsiusTemp} degrees Celsius.");

            int result = (24 + 5) * 8 + 1 - 12;
            Console.WriteLine(result);




        }
    }
}
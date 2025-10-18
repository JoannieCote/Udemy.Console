using System.Xml.Linq;

namespace ConsoleApp.UserInputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables

            string firstName = string.Empty;
            string lastName = string.Empty;
            int age = 0;
            int retirementAge = 65;
            decimal salary = 0;
            char gender = char.MinValue;
            bool working = false;


            // Prompt the user for input

            Console.Write("Please entre your first name: ");
            firstName = Console.ReadLine();

            Console.Write("Please entre your last name: ");
            lastName = Console.ReadLine();

            Console.Write("Please enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your salary: ");
            salary = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Please enter your gender (M ou F)");
            gender = Convert.ToChar(Console.ReadLine());
                
            Console.Write("Are you working? (true ou false)");
            working = Convert.ToBoolean(Console.ReadLine());

            // Process the data

            int workingYearsRemaining = retirementAge - age;

            // Output the result to the user

            Console.WriteLine($"Full name: {firstName} {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Your salary is: {salary}");
            Console.WriteLine($"Your gender is: {gender}");
            Console.WriteLine($"You are Employed: {working}");
            Console.WriteLine($"Working years remaining: {workingYearsRemaining}");
        }
    }
}

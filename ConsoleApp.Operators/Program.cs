namespace ConsoleApp.Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            int num2 = 0;
            Console.Write("Please enter the second number: ");
            string numberEntered = Console.ReadLine();
            num2 = Convert.ToInt32(numberEntered);
            Console.WriteLine();


            // Add numbers
            int sum = (int)(num1 + num2);

            // multiply
            int product = num1 * num2;

            // Division
            int quotient = num1 / num2;

            // Substraction
            int difference = num1 - num2;

            // Modulus
            int mod = num1 % num2;

            Console.WriteLine("********************* Math Results *************************");
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine($"Modulus: {mod}");
            Console.WriteLine();
            Console.WriteLine("********************* End Math Results *************************");
            Console.WriteLine();

            /* Logic operations and operators*/

            var isGreaterThan = num1 > num2;
            bool isLessThan = num1 < num2;
            bool isEqualTo = num1 == num2;
            bool isGreaterThanOrEqualTo = num1 >= num2;
            bool isLessThanOrEqualTo = num1 <= num2;
            bool isNotEqual = num1 != num2;

            Console.WriteLine("********************* Logic Results *************************");
            Console.WriteLine();
            Console.WriteLine($"Is Greater Than: {isGreaterThan}");
            Console.WriteLine($"Is Less Than: {isLessThan}");
            Console.WriteLine($"Is Equal To: {isEqualTo}");
            Console.WriteLine($"Is Greater Than or Equal To: {isGreaterThanOrEqualTo}");
            Console.WriteLine($"Is Less Than Or Equal To: {isLessThanOrEqualTo}");
            Console.WriteLine($"Is Not Equal : {isNotEqual}");
            Console.WriteLine();
            Console.WriteLine("********************* End Logic Results *************************");
            Console.WriteLine();

            /* Assignment operators*/

            Console.WriteLine("Enter Ramdom Value For Assignment Operations");
            int randomValue = Convert.ToInt32(Console.ReadLine());

            //int increaseValue = num1 + 5;
            //num1 = num1 + 5;
            
            Console.WriteLine("********************* Assignments Results *************************");
            Console.WriteLine();
            num1 += randomValue;
            Console.WriteLine($"Num1 increased by {randomValue}: {num1}");
            num1 -= randomValue;
            Console.WriteLine($"Num1 decreased by {randomValue}: {num1}");
            num1 /= randomValue;
            Console.WriteLine($"Num1 divided by {randomValue}: {num1}");
            num1 %= randomValue;
            Console.WriteLine($"Num1 mod {randomValue}: {num1}");
            num1 *= randomValue;
            Console.WriteLine($"Num1 multiplied by {randomValue}: {num1}");
            Console.WriteLine();
            Console.WriteLine("********************* Assignments Results End *************************");
            Console.WriteLine();

        }
    }
}

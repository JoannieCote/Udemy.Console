namespace ConsoleApp.ConditionsAndDecisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt for input

            Console.Write("Please enter student's grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            // Decide to print pass or fail based on input 
            if(grade > 50)
            {
                Console.WriteLine();
                Console.WriteLine("Student has passed");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Student has failed");
                Console.WriteLine("please recommend student to student affair's office");

            }
            Console.WriteLine();
            Console.WriteLine("Thank you for using this program");
        }
    }
}

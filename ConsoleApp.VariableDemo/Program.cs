namespace ConsoleApp.VariableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Trevoir Wiliams";
            string name2 = "Joannie Côté";
            Console.WriteLine(name);
            Console.WriteLine($"Hello, World! {name}");
            Console.WriteLine("I am " + name);
            Console.WriteLine("I was given the name {0} and my name is {1}", name,name2);

            int age = 39;
            Console.WriteLine(age);
            int retirementYearsLeft = 11;
            int retirementAge = age + retirementYearsLeft;

            Console.WriteLine(retirementAge);
            Console.WriteLine(age + retirementYearsLeft);

            bool isRetired = false;
        } 
    }
}

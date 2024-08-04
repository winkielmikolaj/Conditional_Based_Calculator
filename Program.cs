namespace Conditional_Based_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chose what to do:");
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine("/");
            char menu = Convert.ToChar(Console.ReadLine());
            switch (menu)
            {
                case '+':
                    {
                        Console.WriteLine("Enter first number");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter second number");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        int result = num1 + num2;
                        Console.WriteLine($"Your result is {result}");
                    }
                    break;

                case '-':
                    {
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        int result = num1 - num2;
                        Console.WriteLine($"Your result is {result}");
                    }
                    break;

            }
            Console.ReadKey();
        }
    }
}

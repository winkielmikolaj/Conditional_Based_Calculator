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
                        Console.WriteLine("Enter first number");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        int result = num1 + num2;
                        Console.WriteLine($"Your result is {result}");
                    }
                    break;

                case '-':
                    {
                        Console.WriteLine("Enter first number");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter first number");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        int result = num1 - num2;
                        Console.WriteLine($"Your result is {result}");
                    }
                    break;
                case '*':
                    {
                        Console.WriteLine("Enter first number");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter first number");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        int result = num1 * num2;
                        Console.WriteLine($"Your result is {result}");
                    }
                    break;
                case '/':
                    {
                        Console.WriteLine("Enter first number");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter first number");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        if (num1 == 0)
                        {
                            Console.WriteLine("You can not divide by 0!");
                        }
                        else if (num2 == 0)
                        {
                            Console.WriteLine("You can not divide by 0!");
                        }
                        else
                        {
                            int result = num1 / num2;
                            Console.WriteLine($"Your result is {result}");
                        }
                        

                    }
                    break;

            }
            Console.ReadKey();
        }
    }
}

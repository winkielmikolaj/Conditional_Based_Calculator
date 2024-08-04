﻿namespace Conditional_Based_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool validInput = false;
            while (!validInput)
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
                            double num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter first number");
                            double num2 = Convert.ToDouble(Console.ReadLine());
                            double result = num1 + num2;
                            Console.WriteLine($"Your result is {result}");
                            validInput = true;

                        }
                        break;

                    case '-':
                        {
                            Console.WriteLine("Enter first number");
                            double num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter first number");
                            double num2 = Convert.ToDouble(Console.ReadLine());
                            double result = num1 - num2;
                            Console.WriteLine($"Your result is {result}");
                            validInput = true;
                        }
                        break;
                    case '*':
                        {
                            Console.WriteLine("Enter first number");
                            double num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter first number");
                            double num2 = Convert.ToDouble(Console.ReadLine());
                            double result = num1 * num2;
                            Console.WriteLine($"Your result is {result}");
                            validInput = true;
                        }
                        break;
                    case '/':
                        {
                            Console.WriteLine("Enter first number");
                            double num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter first number");
                            double num2 = Convert.ToDouble(Console.ReadLine());
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
                                double result = num1 / num2;
                                Console.WriteLine($"Your result is {result}");
                            }
                            validInput = true;


                        }
                        break;
                    default:
                        {

                            Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
                        }
                        break;

                }
            }

            Console.ReadKey();
        }
    }
}

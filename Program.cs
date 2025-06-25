using System;

namespace CSharpCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Simple C# Calculator ====");

            while (true)
            {
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter an operator (+, -, *, /): ");
                string op = Console.ReadLine();

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                        {
                            Console.WriteLine("❌ Cannot divide by zero!");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("❌ Invalid operator!");
                        continue;
                }

                Console.WriteLine($"✅ Result: {result}");

                Console.Write("Do you want to calculate again? (y/n): ");
                string again = Console.ReadLine().ToLower();
                if (again != "y") break;
            }

            Console.WriteLine("Goodbye 👋");
        }
    }
}
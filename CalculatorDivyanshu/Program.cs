using System;

namespace CalculatorDivyanshu
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, result;
            string operation, choice;
            
            Calculator calc = new Calculator();
            while (true)
            {
                Console.WriteLine("Enter first number: ");
                a = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                b = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Choose operation: +, -, *, / ");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        result = calc.Add(a, b);
                        Console.WriteLine("Result: " + result.ToString());
                        break;
                    case "-":
                        result = calc.Subtract(a, b);
                        Console.WriteLine("Result: " + result.ToString());
                        break;
                    case "*":
                        result = calc.Multiply(a, b);
                        Console.WriteLine("Result: " + result.ToString());
                        break;
                    case "/":
                        result = calc.Divide(a, b);
                        Console.WriteLine("Result: " + result.ToString());
                        break;
                    default:
                        Console.WriteLine("Invalid operation!!");
                        break;
                }
                Console.WriteLine("Do you want to retry? (y/n)");
                choice = Console.ReadLine();
                if (choice == "n" || choice == "N")
                {
                    break;
                }
            }
        }
    }
}

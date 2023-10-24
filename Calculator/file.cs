using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    // Main class
    class Program
    {
        static void Main()
        {
            bool endApp = false;

            while (!endApp)
            {
                // Declare variables
                double a = double.NaN; double b = double.NaN;

                // Title
                Console.WriteLine("Console calculator in C#\r");
                Console.WriteLine("------------------------\n");

                // First number
                Console.WriteLine("Enter your number.");
                a = PromptUntilDouble();

                // Prompting an operation
                Console.WriteLine("Pick an operation");
                Console.WriteLine("\t+ - add");
                Console.WriteLine("\t- - subtract");
                Console.WriteLine("\t* - multiply");
                Console.WriteLine("\t/ - divide");
                Console.WriteLine("\tsin - sinus");
                Console.WriteLine("\tcos - cosinus");
                string oper = Console.ReadLine();

                if (oper != "sin" && oper != "cos") // sin and cos functions require only one argument
                {
                    Console.WriteLine("Enter your second number.");
                    b = PromptUntilDouble();
                }

                // Calculate the result
                try
                {
                    double result = Calculator.DoOperation(a, b, oper);
                    if (double.IsNaN(result)) // DoOperation returns NaN if there is a mathematical error (ex. division by 0)
                    {
                        Console.WriteLine("This calculation will result in a mathematical error!");
                    } else
                    {
                        Console.WriteLine("Result: {0:0.##}", result);
                    }
                } catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occured while trying to calculate.\n - Details: " + e.Message);
                }

                Console.WriteLine("---------------------------\n");

                // Asking if user wants to continue
                Console.WriteLine("Press 'n' to exit or press an other key to continue.");
                if (Console.ReadKey().KeyChar == 'n')
                {
                    endApp = true;
                }

                Console.WriteLine("\n");

            }

        }

        // Utility function asking the user for input until double is received
        static double PromptUntilDouble()
        {
            double num;
            string rawNum = Console.ReadLine();
            while (!double.TryParse(rawNum, out num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                rawNum = Console.ReadLine();
            }
            return num;
        }

    }

    // class carrying out all the calculations
    class Calculator
    {
        public static double DoOperation(double a, double b, string oper)
        {
            switch (oper)
            {
                case "add":
                case "a":
                case "+":
                    {
                        return a + b;
                    }
                case "subtract":
                case "s":
                case "-":
                    {
                        return a - b;
                    }
                case "multiply":
                case "m":
                case "*":
                    {
                        return a * b;
                    }
                case "divide":
                case "d":
                case "/":
                    {
                        if (b != 0D)
                        {
                            return a / b;
                        }
                        return double.NaN;
                    }
                case "sin":
                    {
                        return Math.Sin(a);
                    }
                case "cos":
                    {
                        return Math.Cos(a);
                    }
            }

            return double.NaN;

        }
    }
}

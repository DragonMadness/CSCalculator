using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            bool endApp = false;

            while (!endApp)
            {
                // Declare variables
                double a; double b;

                // Title
                Console.WriteLine("Console calculator in C#\r");
                Console.WriteLine("------------------------\n");

                Console.WriteLine("Enter your first number.");
                string rawA = Console.ReadLine();
                while (!double.TryParse(rawA, out a)) {
                    Console.WriteLine("Incorrect input. Try again.");
                    rawA = Console.ReadLine();
                }

                Console.WriteLine("Enter your second number.");
                string rawB = Console.ReadLine();
                while (!double.TryParse(rawB, out b))
                {
                    Console.WriteLine("Incorrect input. Try again.");
                    rawB = Console.ReadLine();
                }

                Console.WriteLine("Pick an operation");
                Console.WriteLine("\ta - add");
                Console.WriteLine("\ts - subtract");
                Console.WriteLine("\tm - multiply");
                Console.WriteLine("\td - divide");

                string oper;
                while (true)
                {
                    try
                    {
                        oper = Console.ReadLine();
                        break;
                    }
                    catch (IOException) { }
                }

                try
                {
                    double result = Calculator.DoOperation(a, b, oper);
                    if (double.IsNaN(result))
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

                Console.WriteLine("Press 'n' to exit or press an other key to continue.");
                if (Console.ReadKey().KeyChar == 'n')
                {
                    endApp = true;
                }

                Console.WriteLine("\n");

            }

        }

    }

    class Calculator
    {
        public static double DoOperation(double a, double b, string oper)
        {
            switch (oper)
            {
                case "a":
                    {
                        return a + b;
                    }
                case "s":
                    {
                        return a - b;
                    }
                case "m":
                    {
                        return a * b;
                    }
                case "d":
                    {
                        if (b != 0D)
                        {
                            return a / b;
                        }
                        return double.NaN;
                    }
            }

            return double.NaN;

        }
    }
}

using System;

namespace DelegateExample
{
    class Program
    {
        // Declares the delegate with return type (double) and 2 arguments ()

        static void Main(string[] args)
        {
            Console.WriteLine("***Calculator***");

            Console.Write("Input first value: ");
            double value1 = double.Parse(Console.ReadLine());

            Console.Write("Input operator: ");
            char operat = char.Parse(Console.ReadLine());

            Console.Write("Input second value: ");
            double value2 = double.Parse(Console.ReadLine());

            testDelegate(operat, value1, value2);
        }

        delegate double calculatorDelegate(double param1, double param2);
        static void testDelegate(char operat, double value1, double value2)
        {
            calculatorDelegate calculate;

            switch (operat)
            {
                case '+': 
                    calculate = new calculatorDelegate(Add);
                    break;
                case '-':
                    calculate = new calculatorDelegate(Subtract);
                    break;
                case '*':
                    calculate = new calculatorDelegate(Multiply);
                    break;
                case '/':
                    calculate = new calculatorDelegate(Divide);
                    break;
                default:
                    calculate = new calculatorDelegate(Add);
                    break;
            }
            Console.WriteLine("Result is " + calculate(value1, value2)); Console.Read();
        }

        static double Add(double p1, double p2) { return p1 + p2; }
        static double Subtract(double p1, double p2) { return p1 - p2; }
        static double Multiply(double p1, double p2) { return p1 * p2; }
        static double Divide(double p1, double p2) { return p1 / p2; }
    }
}
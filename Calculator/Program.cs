using CalculatorOperations;
using System;

namespace Calculator
{
    public class Program
    {
        private double first_number;
        private double second_number;
        private char operation;
        private double result;

        //public Program(double first_number, double second_number, char operation)
        //{
        //    this.first_number = first_number;
        //    this.second_number = second_number;
        //    this.operation = operation;
        //}

        private double askFirstNumber()
        {
            first_number = Convert.ToDouble(Console.ReadLine());
            return first_number;
        }

        private double askSecondNumber()
        {
            second_number = Convert.ToDouble(Console.ReadLine());
            return second_number;
        }

        private char askTheOperation()
        {
            operation = Convert.ToChar(Console.ReadLine());
            return operation;
        }
        private Operation selectingOperation()
        {
            if (operation == '+')
                return new Sum();
            else if (operation == '-')
                return new Substract();
            else if (operation == '*')
                return new Multiply();
            else
                return new Division();
        }

        public double calculation()
        {
            askFirstNumber();
            askTheOperation();
            do
            {
                askSecondNumber();
                result = CalculatingOperations.compute(first_number, second_number, selectingOperation());
                first_number = result;
                askTheOperation();
            } while (operation != '=');
            return result;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.calculation());
        }
    }
}

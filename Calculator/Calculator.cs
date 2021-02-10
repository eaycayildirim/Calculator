using System;
using System.Collections.Generic;
using System.Text;
using CalculatorOperations;
using System.Linq;

namespace CalculatorMethods
{
    class Calculator
    {
        private string first_number;
        private double second_number;
        private char operation_symbol;
        private double result;

        //public Program(double first_number, double second_number, char operation)
        //{
        //    this.first_number = first_number;
        //    this.second_number = second_number;
        //    this.operation = operation;
        //}

        private double firstNumber()
        {
            List<string> list = new List<string>();
            string input;
            
            while (!list.Contains))
            {
                input = Console.ReadLine();
                if ()
                    break;
                else
                    list.Add(input);
            }

            foreach (var item in list)
            {
                first_number = String.Concat(first_number, item);
            }
            return Convert.ToDouble(first_number);
        }

        private double secondNumber()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        private char operationSymbol()
        {
            operation_symbol = Convert.ToChar(Console.ReadLine());
            return operation_symbol;
        }

        private Operation selectingOperation()
        {
            operationSymbol();
            if (operation_symbol == '+')
                return new Sum();
            else if (operation_symbol == '-')
                return new Substract();
            else if (operation_symbol == '*')
                return new Multiply();
            else
                return new Division();
        }

        public bool isOperationSymbolIsEqual()
        {
            if (operation_symbol == '=')
                return true;
            else
                return false;
        }

        public bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        public double calculation()
        {
            Console.WriteLine(firstNumber());
            //operationSymbol();
            //do
            //{
            //    secondNumber();
            //    result = selectingOperation().calculate(first_number, second_number);
            //    first_number = result;
            //    operationSymbol();
            //} while (operation_symbol != '=');


            return result;
        }
    }
}

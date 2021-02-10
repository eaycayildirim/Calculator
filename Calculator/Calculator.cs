using System;
using System.Collections.Generic;
using System.Text;
using CalculatorOperations;
using System.Linq;

namespace CalculatorMethods
{
    class Calculator
    {
        private double first_number;
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
            string first_number_string = Console.ReadLine();
            
            while (first_number_string.All(char.IsDigit))
            {
                first_number_string = String.Concat(first_number_string, Console.ReadLine());
                if (!first_number_string.All(char.IsDigit))
                {
                    first_number_string = first_number_string.Remove(first_number_string.Length - 1);
                    break;
                }
            }
            first_number = Convert.ToDouble(first_number_string);
            return first_number;
        }

        private double secondNumber()
        {
            string second_number_string = Console.ReadLine();

            while (second_number_string.All(char.IsDigit))
            {
                second_number_string = String.Concat(second_number_string, Console.ReadLine());
                if (!second_number_string.All(char.IsDigit))
                {
                    second_number_string = second_number_string.Remove(second_number_string.Length - 1);
                    break;
                }
            }
            second_number = Convert.ToDouble(second_number_string);
            return second_number;
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

        public double calculation()
        {
            //firstNumber();
            //operationSymbol();
            //do
            //{
            //    secondNumber();
            //    result = selectingOperation().calculate(first_number, second_number);
            //    first_number = result;
            //    operationSymbol();
            //} while (operation_symbol != '=');

            firstNumber();
            while (!isOperationSymbolIsEqual())
            {
                selectingOperation();
                secondNumber();
                result = selectingOperation().calculate(first_number, second_number);
                first_number = result;
                selectingOperation();
            }

            return result;
        }
    }
}

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
            return savingTheNumber();
        }

        private double secondNumber()
        {
            return savingTheNumber();
        }

        public double savingTheNumber()
        {
            char char_number;
            string number = "";

            do
            {
                char_number = Convert.ToChar(Console.ReadLine());
                number += char_number;
                if (!isValidNumber(char_number))
                {
                    operation_symbol = number[number.Length - 1];
                }
            } while (isValidNumber(char_number));
            number = number.Remove(number.Length - 1);

            return Convert.ToDouble(number);
        }

        //private char operationSymbol()
        //{
        //    operation_symbol = Convert.ToChar(Console.ReadLine());
        //    return operation_symbol;
        //}

        private Operation selectingOperation()
        {
            //operationSymbol();
            if (operation_symbol == '+')
                return new Sum();
            else if (operation_symbol == '-')
                return new Substract();
            else if (operation_symbol == '*')
                return new Multiply();
            else if (operation_symbol == '/')
                return new Division();
            else
                throw new Exception();
        }

        public bool isValidNumber(char char_number)
        {
            return (char.IsDigit(char_number) || char_number == ',') ? true : false;
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
            firstNumber();
            selectingOperation();
            while (!isOperationSymbolIsEqual())
            {
                secondNumber();
                result = selectingOperation().calculate(first_number, second_number);
                first_number = result;
                selectingOperation();
            }

            return result;
        }
    }
}

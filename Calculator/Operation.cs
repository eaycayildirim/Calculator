using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorOperations
{
    public interface Operation
    {
        double calculate(double first_number, double second_number);
    }

    public class Sum : Operation
    {
        public double calculate(double first_number, double second_number)
        {
            return first_number + second_number;
        }
    }
    public class Substract : Operation
    {
        public double calculate(double first_number, double second_number)
        {
            return first_number - second_number;
        }
    }
    public class Division : Operation
    {
        public double calculate(double first_number, double second_number)
        {
            return first_number / second_number;
        }
    }
    public class Multiply : Operation
    {
        public double calculate(double first_number, double second_number)
        {
            return first_number * second_number;
        }
    }
    public class Equal
    {
        public Equal()
        {
            this.operation_symbol = '=';
        }
        private char operation_symbol;   
    }
}

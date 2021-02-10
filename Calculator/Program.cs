using CalculatorOperations;
using System;
using CalculatorMethods;

namespace CalculatorMain
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator p = new Calculator();
            Console.WriteLine(p.calculation());
        }
    }
}

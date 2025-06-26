using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 5;

            Console.WriteLine($"Сложение: {a} + {b} = {Calculator.Add(a, b)}");
            Console.WriteLine($"Вычитание: {a} - {b} = {Calculator.Subtract(a, b)}");
            Console.WriteLine($"Умножение: {a} * {b} = {Calculator.Multiply(a, b)}");
            Console.WriteLine($"Деление: {a} / {b} = {Calculator.Divide(a, b)}");
        }
    }
}

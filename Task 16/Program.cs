using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            Console.WriteLine($"PI: {myClass.GetPi()}");
            Console.WriteLine($"Целое число: {myClass.GetInteger()}");
            Console.WriteLine($"Квадрат числа 5: {myClass.Square(5)}");
            Console.WriteLine($"Квадратный корень числа 16: {myClass.SquareRoot(16)}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_16
{
    internal class MyClass : IMathOperations
    {
        public double GetPi()
        {
            return Math.PI;
        }
        public int GetInteger()
        {
            return 42; 
        }
        public double Square(double x)
        {
            return x * x; // возвращает x в квадрате
        }
        public double SquareRoot(double x)
        {
            return Math.Sqrt(x); // возвращает корень из x
        }
    }
}

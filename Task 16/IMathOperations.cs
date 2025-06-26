using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_16
{
    internal interface IMathOperations
    {
        double GetPi(); // метод, возвращающий число PI

        int GetInteger(); // метод, возвращающий число типа int
        double Square(double x); // метод, возвращающий x в квадрате
        double SquareRoot(double x); // метод, возвращающий корень из x



    }
}

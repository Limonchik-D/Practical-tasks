using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_18
{
    internal class Figura
    {
        public void ShowArea(double side)
        {
            double area = side * side;
            Console.WriteLine($"Квадрат, площадь: {area}");
        }

        public void ShowArea(double length, double width)
        {
            double area = length * width;
            Console.WriteLine($"Прямоугольник, площадь: {area}");
        }

        public void ShowArea(double a, double b, double h)
        {
            double area = (a + b) * h / 2;
            Console.WriteLine($"Трапеция, площадь: {area}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пример: треугольник с вершинами A(0,0), B(4,0), C(0,3)
            Point a = new Point(0, 0, "A");
            Point b = new Point(4, 0, "B");
            Point c = new Point(0, 3, "C");

            Figure triangle = new Figure(a, b, c);
            triangle.PerimeterCalculator();

            Console.ReadKey();
        }
    }
}

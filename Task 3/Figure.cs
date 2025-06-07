using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Figure
    {
        private Point[] points;

        public string Name { get; private set; }

        // Конструктор для трёх точек
        public Figure(Point a, Point b, Point c)
        {
            points = new Point[] { a, b, c };
            Name = $"{a.Name}-{b.Name}-{c.Name}";
        }

        // Конструктор для четырёх точек
        public Figure(Point a, Point b, Point c, Point d)
        {
            points = new Point[] { a, b, c, d };
            Name = $"{a.Name}-{b.Name}-{c.Name}-{d.Name}";
        }

        // Конструктор для пяти точек
        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            points = new Point[] { a, b, c, d, e };
            Name = $"{a.Name}-{b.Name}-{c.Name}-{d.Name}-{e.Name}";
        }

        // Метод вычисления длины стороны
        public double LengthSide(Point A, Point B)
        {
            double dx = B.X - A.X;
            double dy = B.Y - A.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        // Метод вычисления периметра
        public void PerimeterCalculator()
        {
            double perimeter = 0;

            for (int i = 0; i < points.Length; i++)
            {
                Point current = points[i];
                Point next = points[(i + 1) % points.Length]; // замыкаем в кольцо
                perimeter += LengthSide(current, next);
            }

            Console.WriteLine($"\nФигура: {Name}");
            Console.WriteLine($"Периметр: {perimeter:F2}");
        }
    }
}

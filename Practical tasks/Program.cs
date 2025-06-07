using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую сторону прямоугольника: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вторую сторону прямоугольника: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine($"Площадь прямоугольника равна: {rectangle.AreaCalculator()}"); //Через метод
            Console.WriteLine($"Периметр прямоугольника равна: {rectangle.Perimeter}"); //Через свойство

            Console.ReadLine();
        }
    }
}

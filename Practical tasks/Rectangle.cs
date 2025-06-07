using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_tasks
{
    internal class Rectangle
    {
        private double side1; //Сторона
        private double side2;

        public Rectangle(double side1, double side2) //Конструктор с параметрами
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalculator() //Площадь прямоугольника
        {
            return side1 * side2;
        }
        public double PerimeterCalculator() //Периметр прямоугольника
        {
            return 2 * (side1 + side2);
        }
        public double Area//Свойство для площади прямоугольника
        {
            get { return AreaCalculator(); }
        }

        public double Perimeter //Свойство для периметра прямоугольника
        {
            get { return PerimeterCalculator(); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    abstract class Vehicle
    {
        public double x; // Координата X
        public double y; // Координата Y
        public double speed { get; set; } // Скорость движения
        public double price { get; set; } // Цена
        public int year { get; set; } // Год выпуска

        public Vehicle(double x, double y, double speed, double price, int year) //Конструктор с параметрами
        {
            this.x = x;
            this.y = y;
            this.speed = speed;
            this.price = price;
            this.year = year;
        }

        public virtual void ShowInfo() //Вывод информации об автомобиле
        {
            Console.WriteLine($"Координаты: ({x}, {y})");
            Console.WriteLine($"Скорость: {speed} км/ч");
            Console.WriteLine($"Цена: {price} руб.");
            Console.WriteLine($"Год выпуска: {year}");
        }
    }
}

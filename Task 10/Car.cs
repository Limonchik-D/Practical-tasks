using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    internal class Car : Vehicle //Автомобиль
    {
        public Car(double x, double y, double speed, double price, int year) : base(x, y, speed, price, year) // Конструктор с параметрами
        { }

        public override void ShowInfo() // Вывод информации об автомобиле
        {
            Console.WriteLine("Автомобиль: ");
            base.ShowInfo(); // Вывод информации из базового класса
        }
    }
}

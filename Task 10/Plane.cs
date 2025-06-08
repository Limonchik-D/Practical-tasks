using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    internal class Plane : Vehicle //Самолёт
    {
        public int height { get; set; } //Высота полёта
        public int passengers { get; set; } //Количество пассажиров

        public Plane(double x, double y, double speed, double price, int year, int height, int passengers) : base(x, y, speed, price, year)
        {
            this.height = height;
            this.passengers = passengers;
        }

        public override void ShowInfo() //Вывод информации о самолёте
        {
            Console.WriteLine("Самолёт: ");
            base.ShowInfo(); //Вывод информации из базового класса
            Console.WriteLine($"Высота полёта: {height} м");
            Console.WriteLine($"Количество пассажиров: {passengers}");
        }
    }
}

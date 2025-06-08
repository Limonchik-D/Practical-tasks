using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    internal class Ship : Vehicle //Корабль
    {
        public int Passengers { get; set; } //Количество пассажиров
        public string Port { get; set; } //Порт назначения

        public Ship(double x, double y, double speed, double price, int year, int passengers, string port) : base(x, y, speed, price, year) //Конструктор с параметрами
        {
            this.Passengers = passengers;
            this.Port = port;
        }

        public override void ShowInfo() //Вывод информации о корабле
        {
            Console.WriteLine("Корабль: ");
            base.ShowInfo(); //Вывод информации из базового класса
            Console.WriteLine($"Количество пассажиров: {    Passengers}");
            Console.WriteLine($"Порт назначения: {Port}");
        }
    }
}

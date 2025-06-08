using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(10, 20, 60, 15000, 2020);
            Plane plane = new Plane(30, 40, 210, 30045, 2018, 320, 45);
            Ship ship = new Ship(50, 60, 30, 2000000, 2015, 500, "Нью-Йорк");
            car.ShowInfo();
            Console.WriteLine();
            plane.ShowInfo();
            Console.WriteLine();
            ship.ShowInfo();    

            Console.ReadLine();

        }
    }
}

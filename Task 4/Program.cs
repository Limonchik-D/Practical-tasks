using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address myAddress = new Address();

            // Заполняем поля
            myAddress.Index = "123456";
            myAddress.Country = "Россия";
            myAddress.City = "Москва";
            myAddress.Street = "Тверская";
            myAddress.House = "15";
            myAddress.Apartment = "101";

            // Выводим на экран
            Console.WriteLine("Адрес:");
            Console.WriteLine($"Индекс: {myAddress.Index}");
            Console.WriteLine($"Страна: {myAddress.Country}");
            Console.WriteLine($"Город: {myAddress.City}");
            Console.WriteLine($"Улица: {myAddress.Street}");
            Console.WriteLine($"Дом: {myAddress.House}");
            Console.WriteLine($"Квартира: {myAddress.Apartment}");

            Console.ReadKey();



        }
    }
}

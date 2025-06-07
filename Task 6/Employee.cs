using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Employee
    {
        private string lastName; //Имя
        private string firstName; //Фамилия
        private string position; //Должность
        private int experience; // стаж в годах
        public Employee(string lastName, string firstName) //Конструктор для имени и фамилии
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }
        public string Position //Должность
        {
            get { return position; }
            set { position = value; }
        }

        // Свойство стажа
        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }

        // Метод для расчета оклада (пример)
        public double CalculateSalary()
        {
            double baseSalary = 0;

            switch (position.ToLower())
            {
                case "junior":
                    baseSalary = 500;
                    break;
                case "middle":
                    baseSalary = 1000;
                    break;
                case "senior":
                    baseSalary = 2000;
                    break;
                case "lead":
                    baseSalary = 3000;
                    break;
                default:
                    baseSalary = 400; // для неопределенных должностей
                    break;
            }

            // Доплата за стаж — например 5% за каждый год
            double bonus = baseSalary * 0.05 * experience;

            return baseSalary + bonus;
        }

        // Метод для расчета налогового сбора (13%)
        public double CalculateTax()
        {
            return CalculateSalary() * 0.13;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Фамилия: {lastName}");
            Console.WriteLine($"Имя: {firstName}");
            Console.WriteLine($"Должность: {position}");
            Console.WriteLine($"Оклад: {CalculateSalary():F2} BYN");
            Console.WriteLine($"Налоговый сбор (13%): {CalculateTax():F2} BYN");
        }
    }
}

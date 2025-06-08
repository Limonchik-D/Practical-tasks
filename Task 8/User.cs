using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    internal class User
    {
        string Login { get; set; } // Логин пользователя
        string FirstName { get; set; } // Имя пользователя
        string LastName { get; set; } // Фамилия пользователя
        int Age { get; set; } // Возраст пользователя

        DateTime DateCreated; // дата заполнения анкеты
        public DateTime GetDateCreated //Только для чтения
        {
           get { return DateCreated; }
        }

        public User(string login, string firatName, string lastName, int age) //Конструктор
        {
            Login = login;
            FirstName = firatName;
            LastName = lastName;
            Age = age;
            DateCreated = DateTime.Now; // Теккущая дата и время
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Логин: {Login}");
            Console.WriteLine($"Имя пользователя: {FirstName}");
            Console.WriteLine($"Фамилия пользователя {LastName}");
            Console.WriteLine($"Возраст пользователя: {Age}");
            Console.WriteLine($"Дата заполнения анкеты: {DateCreated}");

        }




    }
}

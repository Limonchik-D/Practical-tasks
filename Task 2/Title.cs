using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Title
    {
        private string title; //Название книги

        public Title(string title) //Конструктор с параметрами
        {
            this.title = title;
        }

        public void ShowTitle() //Метод для вывода названия
        {
            Console.ForegroundColor = ConsoleColor.Green; //Установка цвета текста
            Console.WriteLine($"Название книги: {title}");
            Console.ResetColor(); //Сброс цвета текста
        }
    }
}

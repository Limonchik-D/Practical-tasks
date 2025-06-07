using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Author
    {
        private string author; //Имя автора

        public Author(string author) //Конструктор с параметрами
        {
            this.author = author;
        }
        public void ShowAuthor() //Метод для вывода
        {
            Console.ForegroundColor = ConsoleColor.Red; //Установка цвета текста
            Console.WriteLine($"Автор: {author}");
            Console.ResetColor(); //Сброс цвета текста
        }
    }
}

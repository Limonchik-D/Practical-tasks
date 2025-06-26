using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20
{
    internal struct Book
    {
        public string Title;      // Название
        public string Author;     // Ф.И.О. автора
        public int Year;          // Год издания
        public int Pages;         // Количество страниц

        // Конструктор
        public Book(string title, string author, int year, int pages)
        {
            Title = title;
            Author = author;
            Year = year;
            Pages = pages;
        }

        // Метод вывода информации
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Title}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Год издания: {Year}");
            Console.WriteLine($"Страниц: {Pages}");
            Console.WriteLine(); 
        }
    }
}

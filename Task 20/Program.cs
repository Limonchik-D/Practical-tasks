using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[3];

            // Инициализируем книги
            books[0] = new Book("Война и мир", "Лев Толстой", 1865, 1225);
            books[1] = new Book("1984", "Джордж Оруэлл", 1949, 328);
            books[2] = new Book("Гарри Поттер", "Дж. К. Роулинг", 1997, 400);

            // Выводим информацию о каждой книге
            foreach (Book book in books)
            {
                book.DisplayInfo();
            }
        }
    }
}

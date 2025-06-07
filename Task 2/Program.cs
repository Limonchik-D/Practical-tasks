using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите название книги: ");
            string title = Console.ReadLine();
            Console.Write("Введите автора книги: ");
            string author = Console.ReadLine();
            Console.Write("Введите содержание книги: ");
            string content = Console.ReadLine();

            Book book = new Book(title, author, content); //объекта класса Book
            Console.WriteLine("Информация о книге: ");
            book.ShowBookInfo(); //Вывод информации о книге

            Console.ReadLine();
        }
    }
}

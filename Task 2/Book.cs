using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Book
    {
        private Title title; //Название книги
        private Author author; //Автор книги
        private Content content; //Содержание книги
        public Book(string titleText, string authorText, string contentText) //Конструктор с параметрами
        {
            title = new Title(titleText);
            author = new Author(authorText);
            content = new Content(contentText);

        }
        public void ShowBookInfo() //Метод для вывода информации о книге
        {
            title.ShowTitle();
            author.ShowAuthor();
            content.ShowContent();
        }
    }
}

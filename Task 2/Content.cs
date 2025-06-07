using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Content
    {
        private string content; //Содержание

        public Content(string content) //Конструктор с парамтерами
        {
            this.content = content;
        }
        public void ShowContent() //Метод для вывода 
        {
            Console.ForegroundColor = ConsoleColor.Yellow; //Установка цвета текста
            Console.WriteLine($"Содержание: {content}");
            Console.ResetColor(); //Сброс цвета текста
        }



    }

}

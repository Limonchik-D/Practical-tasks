using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    internal class RedPrinter : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red; //Установка красного цвета текста
            Console.WriteLine(value); //Вывод текста
            Console.ResetColor();
        }
    }
}

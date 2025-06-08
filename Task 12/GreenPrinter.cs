using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    internal class GreenPrinter : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green; // Устанавливаем зеленый цвет текста
            Console.WriteLine(value);
            Console.ResetColor(); // Сбрасываем цвет текста к стандартному
        }
    }
}

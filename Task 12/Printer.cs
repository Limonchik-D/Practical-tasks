using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    internal class Printer
    {
        public virtual void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Gray; // Устанавливаем цыет  текста по умолчанию
            Console.WriteLine(value);
            Console.ResetColor();

        }
    }
}

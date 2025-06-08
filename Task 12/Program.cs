using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer1 = new Printer();
            Printer printer2 = new RedPrinter(); //Объект наследника
            Printer printer3 = new GreenPrinter(); //Объект наследника

            printer1.Print("Обычный текст");
            RedPrinter redPrinter = (RedPrinter)printer2; // Приводим printer2 к типу RedPrinter
            redPrinter.Print("Красный текст");

            GreenPrinter greenPrinter = (GreenPrinter)printer3; // Приводим printer3 к типу GreenPrinter
            greenPrinter.Print("Зеленый текст"); 

            Console.ReadLine();



        }
    }
}

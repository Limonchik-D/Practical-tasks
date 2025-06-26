using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите тип документа (xml, txt, doc): ");
            string input = Console.ReadLine()?.ToLower();

            AbstractHandler handler;

            switch (input)
            {
                case "xml":
                    handler = new XMLHandler();
                    break;
                case "txt":
                    handler = new TXTHandler();
                    break;
                case "doc":
                    handler = new DOCHandler ();
                    break;
                default:
                    Console.WriteLine("Неизвестный формат документа.");
                    return;
            }

            handler.Open();
            handler.Create();
            handler.Change();
            handler.Save();

            Console.ReadLine();
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(101, "ООО Ромашка", "Завод Цветов", "Цветы", 10, 15.5);

            Console.WriteLine("Вывести сумму с НДС? (да/нет):");
            string answer = Console.ReadLine()?.ToLower();

            bool withVAT = (answer == "да" || answer == "yes");

            invoice.ShowInvoice(withVAT);
                
            Console.ReadKey();
        }
    }
}

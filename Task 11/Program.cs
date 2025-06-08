using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
             Console.WriteLine("Введите ключ доступа (pro, exp) или нажмите Enter для бесплатной версии:");
              string key = Console.ReadLine();

                DocumentWorker worker;

                if (key.ToLower() == "pro")
                {
                    worker = new ProDocumentWorker();
                }
                else if (key.ToLower() == "exp")
                {
                    worker = new ExpertDocumentWorker();
                }
                else
                {
                    worker = new DocumentWorker();
                }

                worker.OpenDocument();
                worker.EditDocument();
                worker.SaveDocument();

                Console.ReadLine();
            
        }
    }
}

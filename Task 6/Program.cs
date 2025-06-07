using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Иванов", "Иван");
            emp.Position = "Middle";
            emp.Experience = 3;

            emp.ShowInfo();

            Console.ReadKey();
        }
    }
}

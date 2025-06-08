using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Limonchik", "Лимон", "Секрет", 16);
            Console.WriteLine("Информация о пользователе: ");
            user.ShowInfo();
            Console.ReadKey();
        }
    }
}

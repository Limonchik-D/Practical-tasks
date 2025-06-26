using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Task_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ISwitchable> devices = new List<ISwitchable>
            {
                new TVSet(),
                new PersonalComputer()
            };

            foreach (var device in devices)
            {
                device.TurnOn();
                device.TurnOff();
                Console.WriteLine(); // Добавлено для разделения вывода
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17
{
    internal class PersonalComputer : ISwitchable
    {
        public void TurnOn()
        {
            Console.WriteLine("Компьютер включен");
        }

        public void TurnOff()
        {
            Console.WriteLine("Компьютер выключен");
        }
    }
}

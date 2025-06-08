using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classRoom = new ClassRoom(
                new ExcellentPupil("Иванов"),
                new GoodPupil("Петров"),
                new BadPupil("Сидоров")
            );

            classRoom.ShowAll();
        }
    }
}

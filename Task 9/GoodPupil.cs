using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    internal class GoodPupil : Pupil //Хорошист
    {
        public GoodPupil(string lastName) : base(lastName) { }

        public override void Study() => Console.WriteLine($"{LastName}: Хорошо учится");
        public override void Read() => Console.WriteLine($"{LastName}: Читает регулярно");
        public override void Write() => Console.WriteLine($"{LastName}: Пишет без ошибок");
        public override void Relax() => Console.WriteLine($"{LastName}: Иногда отдыхает");
    }
}

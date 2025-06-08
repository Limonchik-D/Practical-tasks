using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    internal class ExcellentPupil : Pupil //Отличник
    {
        public ExcellentPupil(string lastName) : base(lastName) 
        {

        }
        public override void Study() => Console.WriteLine($"{LastName}: Отлично учится");
        public override void Read() => Console.WriteLine($"{LastName}: Много читает");
        public override void Write() => Console.WriteLine($"{LastName}: Пишет грамотно");
        public override void Relax() => Console.WriteLine($"{LastName}: Отдыхает разумно");

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    internal class BadPupil : Pupil //Плахишь 
    {
        public BadPupil(string lastName) : base(lastName) { }

        public override void Study() => Console.WriteLine($"{LastName}: Плохо учится");
        public override void Read() => Console.WriteLine($"{LastName}: Не любит читать");
        public override void Write() => Console.WriteLine($"{LastName}: Пишет с ошибками");
        public override void Relax() => Console.WriteLine($"{LastName}: Постоянно отдыхает");
    }
    
}

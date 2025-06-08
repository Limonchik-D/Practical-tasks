using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    abstract class Pupil
    {
        public string LastName { get; } //Фамилия ученика
        public Pupil(string lastName)
        {
            LastName = lastName;
        }
        public abstract void Study();
        public abstract void Read();
        public abstract void Write();
        public abstract void Relax();

    }
}

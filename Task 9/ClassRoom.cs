using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    internal class ClassRoom // Учебный класс
    {
        private Pupil[] pupils = new Pupil[4];

        public ClassRoom(params Pupil[] inputPupils)
        {   
            for (int i = 0; i < inputPupils.Length && i < 4; i++)
            {
                pupils[i] = inputPupils[i];
            }

            for (int i = inputPupils.Length; i < 4; i++)
            {
                pupils[i] = new BadPupil($"Ученик_{i + 1}"); // Заполняем оставшиеся плохими учениками
            }
        }
        public void ShowAll()
        {
            Console.WriteLine("\n=== Информация об учениках ===\n");
            foreach (var pupil in pupils)
            {
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
                Console.WriteLine();
            }
        }
    }
}

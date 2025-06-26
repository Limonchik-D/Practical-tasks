using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    internal class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт DOC-документ");
        }

        public override void Create()
        {
            Console.WriteLine("Создан DOC-документ");
        }

        public override void Change()
        {
            Console.WriteLine("Изменён DOC-документ");
        }

        public override void Save()
        {
            Console.WriteLine("Сохранён DOC-документ");
        }
    }
}

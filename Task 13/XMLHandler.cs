using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    internal class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт XML-документ");
        }

        public override void Create()
        {
            Console.WriteLine("Создан XML-документ");
        }

        public override void Change()
        {
            Console.WriteLine("Изменён XML-документ");
        }

        public override void Save()
        {
            Console.WriteLine("Сохранён XML-документ");
        }
    }
}

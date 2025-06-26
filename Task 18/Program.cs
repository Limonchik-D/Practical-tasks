using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figura figura = new Figura();

            figura.ShowArea(5);              // Квадрат
            figura.ShowArea(4, 6);           // Прямоугольник
            figura.ShowArea(3, 4, 2);        // Трапеция
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Point
    {
        private int x;
        private int y;
        private string name;

        public int X //Свойство
        {
            get { return x; }
        } 
        public int Y
        {
            get { return y; }
        }
        public string Name
        {
            get { return name; }
        }

        public Point(int x, int y, string name) // Конструктор с параметрами
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }
}

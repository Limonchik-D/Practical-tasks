using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14
{
    internal class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Воспроизведение началось.");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Воспроизведение приостановлено.");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Воспроизведение остановлено.");
        }

        public void Record()
        {
            Console.WriteLine("Запись началась.");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Запись приостановлена.");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Запись остановлена.");
        }
    }
}

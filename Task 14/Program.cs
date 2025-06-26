using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Console.WriteLine("IPlayable");
            IPlayable playable = player;
            playable.Play();
            playable.Pause();
            playable.Stop();

            Console.WriteLine("\nIRecodable");
            IRecodable recodable = player;
            recodable.Record();
            recodable.Pause();
            recodable.Stop();
        }
    }
}

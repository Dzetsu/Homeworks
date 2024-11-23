using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player mpPlayer = new Player();
            mpPlayer.Play();
            mpPlayer.Pause();
            mpPlayer.Stop();
            mpPlayer.Record();
        }
    }

    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Играет");
        }
        public void Pause()
        {
            Console.WriteLine("Пауза");
        }
        public void Stop()
        {
            Console.WriteLine("Закончить");
        }
        public void Record()
        {
            Console.WriteLine("Записывает");
        }
    }

    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }
}

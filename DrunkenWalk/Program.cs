using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DrunkenWalk
{
    class Program
    {
        public static Game _Game = new Game(WIDTH, HEIGHT);

        public const int WIDTH = 50;
        public const int HEIGHT = 30;

        static void Main(string[] args)
        {
            Console.SetWindowSize(WIDTH, HEIGHT);

            while (_Game.isRunning)
            {
                _Game.Tick();
                Console.ReadKey();
            }

            Console.ReadKey();
        }

        
    }
}

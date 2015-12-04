using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrunkenWalk
{
    class Game
    {

        public bool isRunning = false;

        private const int WALK_DISTANCE = 3000;
        
        private int width;
        private int height;

        private Dungeon _Dungeon;

        public Game(int width, int height)
        {
            isRunning = true;

            this.width = width;
            this.height = height;

            _Dungeon = new Dungeon(width, height, WALK_DISTANCE);
        }

        public void Tick ()
        {
            Console.Clear();
            Display();
        }

        public void Display()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (_Dungeon.Grid[x, y].IsEmpty)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    Console.Write(" ");
                }
                if (y < height - 1) Console.WriteLine();
            }
        }
    }
}

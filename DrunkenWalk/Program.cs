using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrunkenWalk
{
    class Program
    {
        public static Dungeon dungeon = new Dungeon(WIDTH, HEIGHT);

        public const int WIDTH = 30;
        public const int HEIGHT = 20;
        public const int WALK_DISTANCE = 2000;

        static void Main(string[] args)
        {
            Console.SetWindowSize(WIDTH, HEIGHT);

            dungeon.DrunkenWalk(WALK_DISTANCE, WIDTH, HEIGHT);
            // pick a random point of a filled grid
            // mark that point empty
            // choose a random cardinal
            // move to that point and mark it empty
            // repeat 2-3 until you have emptied as much as you want
            Update();
            Console.ReadKey();
        }

        private static void Update()
        {
            for (int y = 0; y < HEIGHT; y++)
            {
                for (int x = 0; x < WIDTH; x++)
                {
                    if (dungeon.Grid[x, y].IsEmpty)
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
                Console.WriteLine();
            }
        }
    }
}

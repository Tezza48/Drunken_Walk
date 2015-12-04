using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrunkenWalk
{
    class Dungeon
    {
        private Cell[,] grid;

        public Dungeon(int width, int height)
        {
            grid = new Cell[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    grid[x, y] = new Cell();
                }
            }
        }

        internal Cell[,] Grid
        {
            get
            {
                return grid;
            }

            set
            {
                grid = value;
            }
        }

        public void DrunkenWalk (int distance, int width, int height)
        {
            Random rand = new Random();
            int[] point = { rand.Next(0, width), rand.Next(0, height) };
            for (int i = 0; i < distance; i++)
            {
                grid[point[0], point[1]].IsEmpty = true;
                int direction = rand.Next(0, 4);
                switch (direction)
                {
                    case 0:
                        if (point[1] > 0) point[1]--;
                        else point[1]++;
                        break;
                    case 1:
                        if (point[0] < width - 1) point[0]++;
                        else point[0]--;
                        break;
                    case 2:
                        if (point[1] < height - 1) point[1]++;
                        else point[1]--;
                        break;
                    case 3:
                        if (point[0] > 0) point[0]--;
                        else point[0]++;
                        break;
                }
            }
        }
    }
}

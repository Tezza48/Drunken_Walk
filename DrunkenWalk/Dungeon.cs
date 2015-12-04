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
        private int width;
        private int height;
        private int distance;

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

        public Dungeon(int width, int height, int distance)
        {
            this.width = width;
            this.height = height;
            this.distance = distance;

            Grid = new Cell[width, height];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Grid[x, y] = new Cell();
                }
            }

            DrunkenWalk();
        }

        public void DrunkenWalk ()
        {
            Random rand = new Random();
            int[] point = { rand.Next(0, width), rand.Next(0, height) };
            for (int i = 0; i < distance; i++)
            {
                Grid[point[0], point[1]].IsEmpty = true;
                int direction = rand.Next(0, 4);
                switch (direction)
                {
                    case 0:
                        if (point[1] > 1) point[1]--;
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
                        if (point[0] > 1) point[0]--;
                        else point[0]++;
                        break;
                }
            }
        }
    }
}

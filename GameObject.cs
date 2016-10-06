using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeMess
{
    abstract class GameObject
    {
        public int CoordX { get; set; }
        public int CoordY { get; set; }
        public char Character { get; set; }
        public ConsoleColor Color { get; set; }

        public GameObject(int startCoordX, int startCoordY, char character, ConsoleColor color)
        {
            CoordX = startCoordX;
            CoordY = startCoordY;
            Character = character;
            Color = color;
        }
    }
}

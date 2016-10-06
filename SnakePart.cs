using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeMess
{
    class SnakePart:GameObject
    {

        public SnakePart(int coordX, int coordY, char character)
            :base(coordX,coordY,character,ConsoleColor.Green)
        {

        }

		public SnakePart(SnakePart snakepart)
			:this(snakepart.CoordX,snakepart.CoordY,snakepart.Character)
		{

		}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeMess
{
    class Apple:GameObject
    {
        public Apple(int coordX, int coordY)
            :base(coordX,coordY,'$',ConsoleColor.Red)
        {

        }

        public Apple()
            :this(0, 0)
        {

        }
    }
}

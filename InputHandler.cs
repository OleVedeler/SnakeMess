using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace SnakeMess
{
    public class InputHandler
    {
		private static readonly InputHandler instance = new InputHandler();

		public static InputHandler Instance{
			get
			{
				return instance;
			}
		}

		private ConsoleKeyInfo input;
        
		public void UpdateInput()
		{
            input = Console.ReadKey(true);
		}
        
		public bool Escape()
        {	
			return input.Key == ConsoleKey.Escape;
		}
		public bool Space()
        {  
            return input.Key == ConsoleKey.Spacebar;
		}
        public bool Left()
        {
            return input.Key == ConsoleKey.LeftArrow;
        }
        public bool Right()
        {
            return input.Key == ConsoleKey.RightArrow;
        }
        public bool Up()
        {
            return input.Key == ConsoleKey.UpArrow;
        }
        public bool Down()
        {
            return input.Key == ConsoleKey.DownArrow;
        }
    }
}

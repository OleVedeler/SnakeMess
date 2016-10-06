using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeMess
{
    class View
    {
		private SnakePart currentHead;
		private SnakePart previousHead;
        private SnakePart Tail;
        private Apple Apple;
	
        public Model CurrentModel { get; set; }

        public View(Model model)
        {
			CurrentModel = model;
			UpdateCurrentGameObjectInfo();
            UpdatePreviousGameObjectInfo();
        }


		private void UpdateCurrentGameObjectInfo()
		{
            Apple = CurrentModel.AppleObject;
			currentHead = CurrentModel.GetSnakeHead();
            Tail = CurrentModel.GetSnakeTail();
		}

		private void UpdatePreviousGameObjectInfo()
		{
            previousHead = currentHead;    
		}

        public void UpdateView()
        {
			UpdateCurrentGameObjectInfo();
            
            //Draw previous head as a body part
			Console.ForegroundColor = previousHead.Color;
			Console.SetCursorPosition(previousHead.CoordX, previousHead.CoordY);
            Console.Write(previousHead.Character);

            //draw last part of the snake blank
		    Console.SetCursorPosition( Tail.CoordX, Tail.CoordY );
			Console.Write( " " );

            //Draw new head
			Console.ForegroundColor = currentHead.Color;
			Console.SetCursorPosition(currentHead.CoordX, currentHead.CoordY);
			Console.Write(currentHead.Character);
            
            //Draw Apple
            Console.ForegroundColor = Apple.Color;
            Console.SetCursorPosition(Apple.CoordX, Apple.CoordY);
            Console.Write(Apple.Character);
            
            UpdatePreviousGameObjectInfo();

        }
    }
}

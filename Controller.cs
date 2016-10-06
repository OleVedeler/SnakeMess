using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace SnakeMess
{
    class Controller
    {
        private Model model;
        private View view;
		private Direction lastDirection;
		private Direction newDirection;
		private bool pause;
        private bool gameOver;

        public Controller()
        {
            Console.CursorVisible = false;
			model = new Model();
			view = new View(model);
			newDirection=Direction.DOWN;
			lastDirection=newDirection;
			GameLoop();
        }


		public void GameLoop(){
			Stopwatch gametimer = new Stopwatch();
			gametimer.Start();

			while(!gameOver){

                UserInput();

                if(gametimer.ElapsedMilliseconds < 100 || pause)
					continue;

                gametimer.Restart();

                model.MoveSnake(newDirection);

				lastDirection = newDirection;

				if (model.CheckAppleCollision()) {
					model.PlaceApple();
				} else {
					model.RemoveSnakePart();
				}

                if (model.CheckDeathCollision())
                {
                    gameOver = true;
                    continue;
                }
                
                model.AddSnakeHead();
				view.UpdateView();
            } 
		}

        public void UserInput()
        {
			if ( Console.KeyAvailable )
			{
                InputHandler.Instance.UpdateInput();
                if (InputHandler.Instance.Up() && lastDirection != Direction.DOWN)
                    newDirection = Direction.UP;
                else if (InputHandler.Instance.Right() && lastDirection != Direction.LEFT)
                    newDirection = Direction.RIGHT;
                else if (InputHandler.Instance.Down() && lastDirection != Direction.UP)
                    newDirection = Direction.DOWN;
                else if (InputHandler.Instance.Left() && lastDirection != Direction.RIGHT)
                    newDirection = Direction.LEFT;
                else if (InputHandler.Instance.Space())
                    pause = !pause;
                else if (InputHandler.Instance.Escape())
                    gameOver = true;
			}
        }
    }
}

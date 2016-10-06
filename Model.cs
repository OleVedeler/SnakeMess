using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace SnakeMess{

    public enum Direction
    {
        LEFT,
        RIGHT,
        UP,
        DOWN
    }

    class Model
    {
		private int windowWidth;
		private int windowHeight;
		private Random randomGenerator;
		private List<SnakePart> snakePartList;
		private SnakePart newHead;
        public Apple AppleObject { get; set; }
		 
        public Model()
        {
			windowWidth=Console.WindowWidth;
			windowHeight=Console.WindowHeight;
			snakePartList=new List<SnakePart>();
			randomGenerator=new Random();
            AppleObject = new Apple();
            SnakeBirth();
            PlaceApple();
        }

		public void SnakeBirth(){
			for (int i = 0; i < 5; i++) {
				snakePartList.Add( new SnakePart(10, 10, 'O')); 			
			}
		}

        public void AddSnakeHead()
        {
			snakePartList.Last().Character = 'O';
			snakePartList.Add(newHead);
            snakePartList.Last().Character = '@';
        }

        public void RemoveSnakePart()
        {
			snakePartList.RemoveAt(0);
        }

        public void PlaceApple()
        {
			bool isOnSnake;
			do {
				AppleObject.CoordX = randomGenerator.Next( 0, Console.WindowWidth );
	            AppleObject.CoordY = randomGenerator.Next( 0, Console.WindowHeight );
				isOnSnake = false;
				foreach ( SnakePart part in snakePartList )
					if ( part.CoordX == AppleObject.CoordX && part.CoordY == AppleObject.CoordY)
					{
						isOnSnake = true;
						break;
						// Breaks if the random spot is on the snake
					}
			} while(isOnSnake);
        }

        public void MoveSnake(Direction direction)
        {
			newHead = new SnakePart(snakePartList.Last());
			switch(direction) 
			{
                case Direction.UP:      newHead.CoordY -= 1; break;
                default:  //DOWN
                case Direction.DOWN:    newHead.CoordY += 1; break;
                case Direction.RIGHT:   newHead.CoordX += 1; break;
                case Direction.LEFT:    newHead.CoordX -= 1; break;
			}
        }

		public bool CheckAppleCollision()
		{
			return ( newHead.CoordX == AppleObject.CoordX && newHead.CoordY == AppleObject.CoordY );
		}

		public bool CheckDeathCollision()
		{
            if (newHead.CoordX < 0 || newHead.CoordX >= windowWidth 
                || newHead.CoordY < 0 || newHead.CoordY >= windowHeight)
            {
                return true;
            }
            
            foreach (SnakePart part in snakePartList)
            {
                if (newHead.CoordX == part.CoordX && newHead.CoordY == part.CoordY )
                    return true;
            }
			
            return false;
		}

		public SnakePart GetSnakeHead() {
			return snakePartList.Last();
		}

		public SnakePart GetSnakeTail() {
			return snakePartList.First();
		}
    }
}

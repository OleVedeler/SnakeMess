using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

// WARNING: DO NOT code like this. Please. EVER! 
//          "Aaaargh!" 
//          "My eyes bleed!" 
//          "I facepalmed my facepalm." 
//          Etc.
//          I had a lot of fun obfuscating this code though! And I can now (proudly?) say that this is the ugliest short piece of code I've ever worked with! :-)
//          (And yes, it could have been a lot uglier! But the idea wasn't to make it fugly-ugly, just funny-ugly, sweet-ugly, or whatever you want to call it.)
//
//          -Tomas
//
namespace SnakeMess
{
	/*class Coord
	{
		public int X; public int Y;
        public Coord( int x = 0, int y = 0 ) { X = x; Y = y; }
        public Coord( Coord input ) { X = input.X; Y = input.Y; }
    }*/

    class SnakeMess
	{
		public static void Main( string[] arguments )
		{

			Controller control = new Controller();
			/*
            bool gameOver = false, pause = false, hasEatenApple = false;
			short newDirection = 2; // 0 = up, 1 = right, 2 = down, 3 = left
			short lastDirection = newDirection;
            int boardWidth = Console.WindowWidth, boardHeight = Console.WindowHeight;
            Random randomGenerator = new Random();
            Coord apple = new Coord();
            List<Coord> snake = new List<Coord>();
			
			// Makes the snake body
			for (int i = 0; i < 4; i++){
				snake.Add( new Coord( 10, 10 ) ); 
			}
            
			// Hides cursor
            Console.CursorVisible = false;
			
			// Sets color of text/snake
            Console.ForegroundColor = ConsoleColor.Green;
			
			// Makes the head of the snake
            Console.SetCursorPosition( 10, 10 );
            Console.Write( "@" );
			
            while ( true )
			{
				// Make method placeApple();
				apple.X = randomGenerator.Next( 0, boardWidth );
                apple.Y = randomGenerator.Next( 0, boardHeight );
				
				// Checks if the random generated coords are on the snake or not
				bool isOnSnake = false;
				foreach ( Coord i in snake )
					if ( i.X == apple.X && i.Y == apple.Y )
					{
						isOnSnake = true;
						break;
					// Breaks if the random spot is on the snake
					}
				
				// Places the apple if not on snake
				if ( !isOnSnake )
				{
					Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition( apple.X, apple.Y ); 
                    Console.Write( "$" );
					break;
				}
			}
			
			// Creates and starts timer
			Stopwatch gameTime = new Stopwatch();
			gameTime.Start();
			
			// Create class inputhandler
			while ( !gameOver )
			{
				if ( Console.KeyAvailable )
				{
					// Flyttet til Controller.cs
					ConsoleKeyInfo cki = Console.ReadKey( true );
					if ( cki.Key == ConsoleKey.Escape )
						gameOver = true;
					else if ( cki.Key == ConsoleKey.Spacebar )
						pause = !pause;
					else if ( cki.Key == ConsoleKey.UpArrow && lastDirection != 2 )
						newDirection = 0;
					else if ( cki.Key == ConsoleKey.RightArrow && lastDirection != 3 )
						newDirection = 1;
					else if ( cki.Key == ConsoleKey.DownArrow && lastDirection != 0 )
						newDirection = 2;
					else if ( cki.Key == ConsoleKey.LeftArrow && lastDirection != 1 )
						newDirection = 3;
				}
				
				if ( !pause )
				{
					// If under 100ms, don't update snake
					if ( gameTime.ElapsedMilliseconds < 1000 )
						continue;
					
					gameTime.Restart();
					Coord tail = new Coord(snake.First());
					Coord head = new Coord(snake.Last());
					Coord newHead = new Coord(head);
					
					switch ( newDirection )
					{
						case 0:
							newHead.Y -= 1;
							break;
						case 1:
							newHead.X += 1;
							break;
						case 2:
							newHead.Y += 1;
							break;
						case 3:
						default:
							newHead.X -= 1;
							break;
					}
					
					// If head on wall, 
					if ( newHead.X < 0 || newHead.X >= boardWidth || newHead.Y < 0 || newHead.Y >= boardHeight)
						gameOver = true;

					if ( newHead.X == apple.X && newHead.Y == apple.Y )
					{
						if ( snake.Count + 1 >= boardWidth * boardHeight )
							// No more room to place apples -- game over.
							gameOver = true;
						else
						{
							while ( true )
							{
								apple.X = randomGenerator.Next( 0, boardWidth );
                                apple.Y = randomGenerator.Next( 0, boardHeight );
								bool isAppleOnSnake = false;
								
                                foreach ( Coord snakePart in snake )
									if ( snakePart.X == apple.X && snakePart.Y == apple.Y )
									{
										isAppleOnSnake = true;
										break;
									}
								if ( !isAppleOnSnake )
								{
									hasEatenApple = true;
									break;
								}
							}
						}
					}
					
					// Skips removing last part of snake if apple has been eaten
					if ( !hasEatenApple )
					{
						// Removes last part of snake body if apple not eaten
						snake.RemoveAt( 0 );
						
						// Checks if newHead will crash with body
						foreach ( Coord snakePart in snake )
							if ( snakePart.X == newHead.X && snakePart.Y == newHead.Y )
							{
								// Death by accidental self-cannibalism.
								gameOver = true;
								break;
							}
					}
					
					// Kan fjerne dette, lar det stå enn så lenge
					//if ( !gameOver )
					{
						// Replaces previous head position with body part
						Console.ForegroundColor = ConsoleColor.Green; 
                        Console.SetCursorPosition( head.X, head.Y );
                        Console.Write( "O" );
						
						// Replaces last body part with space
                        if ( !hasEatenApple )
						{
							Console.SetCursorPosition( tail.X, tail.Y );
                            Console.Write( " " );
						}
						
						// If apple is consumed, creates new apple
						else
						{
							Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition( apple.X, apple.Y );
                            Console.Write( "$" );
							hasEatenApple = false;
						}
						
						// Adds new head, and draws it
						snake.Add( newHead );
						Console.ForegroundColor = ConsoleColor.Green; 
                        Console.SetCursorPosition( newHead.X, newHead.Y );
                        Console.Write( "@" );
						lastDirection = newDirection;
					}
				}
			}*/
		}
	}
}
using EZInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
      static  PlayerEnemy game=new PlayerEnemy(); 
        static void Main(string[] args)
        {

            Console.Clear();
            maze();
            printPlayer();
            while (true)
            {
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    movePlayerLeft();
                }

                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    movePlayerRight();
                }
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    movePlayerUp();
                }
                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    movePlayerDown();
                }
                moveEnemy();
                Thread.Sleep(300);
            } 
            
                
               
               

            
        }
       static void movePlayerLeft()
        {
           
            {
                erasePlayer();
              game.pX = game.pX - 1;
                printPlayer();

            }
        }

        static void movePlayerRight()
        {

            {
                erasePlayer();
                game.pX = game.pX + 1;
                printPlayer();

            }
        }

        static void movePlayerUp()
        {

            {
                erasePlayer();
                game.pY = game.pY - 1;
                printPlayer();

            }
        }
        static void movePlayerDown()
        {

            {
                erasePlayer();
                game.pY = game.pY + 1;
                printPlayer();

            }
        }
       static void moveEnemy()
        {
            eraseEnemy();
            game.eX1 = game.eX1 + 1;
            if (game.eX1 == 120)
            {
                game.eX1 = 2;
            }
            printEnemy();

        }

        static void maze()
        {

            Console.WriteLine(" ###############################################################");
            Console.WriteLine(" #                                                             #");
            Console.WriteLine(" #                                                             #");
            Console.WriteLine(" #                                                             #");
            Console.WriteLine(" #                                                             #");
            Console.WriteLine(" #                                                             #");
            Console.WriteLine(" #                                                             #");
            Console.WriteLine(" #                                                             #");
            Console.WriteLine(" #                                                             #");
            Console.WriteLine(" #                                                             #");
            Console.WriteLine(" #                                                             #");
            Console.WriteLine(" #                                                             #");
            Console.WriteLine(" #                                                             #");
            Console.WriteLine(" #                                                             #");
            Console.WriteLine(" #                                                             #");
            Console.WriteLine(" #                                                             #");
            Console.WriteLine(" #                                                             #");
            Console.WriteLine(" #                                                             #");
            Console.WriteLine(" #                                                             #");
            Console.WriteLine(" #                                                             #");
            Console.WriteLine(" #                                                             #");
            Console.WriteLine(" #                                                             #");
            Console.WriteLine(" #                                                             #");
            Console.WriteLine(" #                                                             #");
            Console.WriteLine(" #                                                             #");
            Console.WriteLine(" ###############################################################");

        }
        static void printPlayer()
        {
            Console.SetCursorPosition(game.pX, game.pY);
            Console.WriteLine("P");
        }

        static void printEnemy()
        {
            Console.SetCursorPosition(game.eX1, game.eY1);
            Console.WriteLine("E");
        }
        static void eraseEnemy()
        {
            Console.SetCursorPosition(game.eX1, game.eY1);
            Console.WriteLine(" ");
        }
        static void erasePlayer()
        {
            Console.SetCursorPosition(game.pX, game.pY);

            Console.WriteLine(" ");
        }

    }
}

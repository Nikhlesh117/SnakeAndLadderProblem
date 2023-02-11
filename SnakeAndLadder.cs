using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class SnakeAndLadder
    {
        public static void Game()
        {
            int Player1 = 0;
            int Player2 = 0;

            int dice1;
            int dice2;

            int option;

            int temp1 = 0;
            int temp2 = 0;

            int count = 0;

            Console.WriteLine("\nWelcome Players");
            Console.WriteLine("Player at Player1 : " + Player1);
            Console.WriteLine("Player at Player2 : " + Player2);

            Random random = new Random();

            while (Player1 < 100 && Player2 < 100)
            {
                dice1 = random.Next(1,7);
                dice2 = random.Next(1,7);

                count++;

                Console.WriteLine("\nPlayer1 rolls dice :" + dice1);
                Console.WriteLine("\nPlayer2 rolls dice :" + dice2);
                Console.WriteLine("\nNumber of dice roll :" + count);

                option = random.Next(0, 3);

                switch(option)
                {
                    case 0:
                        Console.WriteLine("No Play");
                        break;
                    case 1:
                        Console.WriteLine("Player1 Ladder");
                        Player1 += dice1;
                        Console.WriteLine("Player2 Ladder");
                        Player2 += dice2;
                        break;
                    case 2:
                        Console.WriteLine("Player1 Snake");
                        Player1 -= dice1;
                        Console.WriteLine("Player2 Snake");
                        Player2 -= dice2;
                        break;
                }
                if (Player1 < 0)
                {
                    Player1 = 0;
                }
                if (Player1 > 100)
                {
                    Player1 = temp1;
                }

                if (Player2 < 0)
                {
                    Player2 = 0;
                }
                if (Player2 > 100)
                {
                    Player2 = temp2;
                }
                Console.WriteLine("Player1 Current position : " + Player1);
                Console.WriteLine("Player2 Current position : " + Player2);

            }
            Console.WriteLine("Player1 position : " + Player1);
            Console.WriteLine("Player2 position : " + Player2);
            Console.WriteLine("\nNumber of dice roll :" + count);

            if (Player1 == 100)
            {
                Console.WriteLine("Player1 Wins!");
            }
            else if (Player2 == 100)
            {
                Console.WriteLine("Player2 Wins");
            }
            else
            {
                Console.WriteLine("Tie");
            }
        }
    }
}

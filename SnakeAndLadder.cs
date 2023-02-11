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
            int position = 0;

            Console.WriteLine("\nWelcome Player");
            Console.WriteLine("Player at position : " + position);


            int dice;

            Random random = new Random();
            dice = random.Next(1, 7);

            Console.WriteLine("\nPlayer rolls dice :" + dice);

            int option;

            option = random.Next(0, 3);

            switch(option)
            {
                case 0:
                    Console.WriteLine("No Play");
                    break;
                case 1:
                    Console.WriteLine("Ladder");
                    position += dice;
                    break;
                case 2:
                    Console.WriteLine("Snake");
                    position -= dice;
                    break;
            }
            Console.WriteLine("Player Current Position : " + position);


        }
    }
}

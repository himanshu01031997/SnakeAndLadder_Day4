using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Snake
    {
        public int PlayerPosition = 0;
        public const int Noplay = 0, Ladder = 1, Snakee = 2;

        Random random = new Random();

        public int DiceRoll()
        {
            int Dicecount= random.Next(0,7);
            return Dicecount;

        }
        public void Play()
        {
            int choice= random.Next(0,3);
            while (PlayerPosition <= 100)
            {
                switch (choice)
                {
                    case Noplay:
                        PlayerPosition += 0;
                        break;
                    case Ladder:
                        PlayerPosition += DiceRoll();
                        break;
                    case Snakee:
                        PlayerPosition -= DiceRoll();
                        if (PlayerPosition<0)
                        {
                            PlayerPosition = 0;
                        }
                        break;
                    default:
                        Console.WriteLine("invalid data");
                        break;
                }
                Console.WriteLine(PlayerPosition);

            }


        }
    }
}

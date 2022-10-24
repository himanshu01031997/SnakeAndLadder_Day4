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
        public void CheckforOption()
        {
            int choice= random.Next(0,3);
            switch (choice)
            {
                case Noplay:
                    PlayerPosition += 0;
                    Console.WriteLine("player is at same place");
                    break;
                case Ladder:
                    PlayerPosition+=DiceRoll();
                    Console.WriteLine("player is at {0}", PlayerPosition);
                    break;
                case Snakee:
                    PlayerPosition-=DiceRoll();
                    Console.WriteLine("player is at {0}",PlayerPosition);
                    break;
                default:
                    Console.WriteLine("invalid data");
                    break;
            }
        }
    }
}

namespace SnakeAndLadder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Snake snake = new Snake();
            // Console.WriteLine("Initial Position is {0}",snake.initialPosition);
            Console.WriteLine("get number After Dice Roll is {0}",snake.DiceRoll()); 
        }
    }
}
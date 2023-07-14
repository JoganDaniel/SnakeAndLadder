using System;

namespace SnakeAndLadder
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladders Program");
            SnakeAndLadders player1 = new SnakeAndLadders();
            SnakeAndLadders player2 = new SnakeAndLadders();
            while (!player1.isWinning() || !player2.isWinning() )
            {
                player1.Game();
                player2.Game();
            }
            if (player1.isWinning() == true)
            {
                Console.WriteLine("Player1 wins");
                Console.WriteLine("number of die throws " + player1.getCount());
            }
            else if(player2.isWinning() == true)
            {
                Console.WriteLine("Player2 wins");
                Console.WriteLine("number of die throws " + player2.getCount());
            }
        }
    }
}

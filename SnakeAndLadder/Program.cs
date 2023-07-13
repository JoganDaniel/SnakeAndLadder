using System;

namespace SnakeAndLadder
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snake and ladder program");
            SnakeAndLadders snakeAndLadders = new SnakeAndLadders();
            snakeAndLadders.DieRoll();
        }
    }
}
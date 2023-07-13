using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeAndLadders
    {
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100, STARTING_POSITION = 0;
     
        int position = 0;
        int count = 0;

        
        Random random = new Random();
        public int DieRoll()
        {
            int diePosition = random.Next(1, 7);
            Console.WriteLine("Position is " + this.position);
            count++;
            return diePosition;
        }
    }
}

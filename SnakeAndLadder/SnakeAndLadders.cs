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
        bool win = false;

        public void setPosition(int position)
        {
            this.position = position;
        }
        public int getPosition()
        {
            return position;
        }
        public int getCount()
        {
            return count;
        }
        public void setCount(int count)
        {
            this.count = count;
        }
        public bool isWinning()
        {
            return win;
        }
        public void setWin(bool win)
        {
            this.win = win;
        }

        Random random = new Random();
        public int DieRoll()
        {
            int diePosition = random.Next(1, 7);
            this.count++;
            return diePosition;
        }

        public void Game()
        {
            int dieRoll = DieRoll();
                int option = random.Next(0, 3);
                switch (option)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        if (this.position + dieRoll <= WINNING_POSITION)
                        {
                            this.position += dieRoll;
                        }
                        Game(); 
                        break;
                    case SNAKE:
                        if (this.position - dieRoll < STARTING_POSITION)
                        {
                            this.position = 0;
                        }
                        else
                        {
                            this.position -= dieRoll;
                        }
                        break;
                }
            if (this.position == WINNING_POSITION)
            {
                this.win = true;
            }

        }
    }
}

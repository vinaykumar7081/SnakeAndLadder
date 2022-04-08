using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    public class SnakeGame
    {
        const int NO_PLAY = 0, SNAKE = 1, LADDER = 2;
        int position = 0;
        int count = 0;
        public int dieRoll()
        {
            Random random = new Random();
            int diePosition = random.Next(1,7);
            return diePosition;
        }
        public void gamePlaying()
        {
            while (this.position < 100)
            {
                Random random = new Random();
                int roll = random.Next(0, 3);

                switch (roll)
                {
                    case NO_PLAY:
                        this.position += 0;
                        break;
                    case SNAKE:
                        this.position -= this.dieRoll();
                        if (this.position < 0)
                        {
                            this.position = 0;
                        }
                        break;
                    case LADDER:
                        int maxValue= this.dieRoll();
                        this.position += maxValue;
                        if (this.position >100)
                        {
                            this.position -= maxValue;
                        }
                        break;
                }
                count++;

            }
            Console.WriteLine("The number of Dice to win the match"+"  "+count);
            Console.WriteLine("You Have win with "+this.position+ " "+" Number");

        }
        
    }
}

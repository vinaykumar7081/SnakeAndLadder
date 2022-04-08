using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadderAndSnakeGame
{
    internal class SnakeGame
    {
        const int NO_PLAY = 0, SNAKE = 1, LADDER = 2;
        int roll1 = 0, roll2 = 0, position = 0;

        public int dieRoll()
        {
            Random random = new Random();
            int diePosition = random.Next(1, 7);
            return diePosition;
        }
        public void playingGame()
        {

            while (this.position < 100)
            {

                Random random1 = new Random();
                int player1 = random1.Next(0, 3);

                Random random2 = new Random();
                int player2 = random2.Next(0, 3);

                if (player1.Equals(LADDER))
                {
                    this.position += this.dieRoll();
                    roll1 += this.position;
                    continue;
                }
                else if (player2.Equals(LADDER))
                {
                    this.position += this.dieRoll();
                    roll1 += this.position;
                    continue;
                }
                else if (player1.Equals(SNAKE))
                {
                    this.position -= this.dieRoll();
                    roll1 += this.position;
                }
                else if (player2.Equals(SNAKE))
                {
                    this.position -= this.dieRoll();
                    roll2 += this.position;
                }
            }
            if (roll1 > roll2)
            {
                Console.WriteLine("Player First is Winner with" + " " + roll1);
            }
            else if (roll2 > roll1)
            {
                Console.WriteLine("Player Second is Winner with" + " " + roll2);
            }
            else
            {
                Console.WriteLine("Game is tie");
            }
            Console.WriteLine("First Player getting number is " + " " + roll1);
            Console.WriteLine("Second Player getting number is " + " " + roll2);

        }
    }
}

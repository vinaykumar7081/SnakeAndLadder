using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    public class SnakeGame
    {
        const int position = 0;
        public int dieRoll()
        { 
            Random random = new Random();
            int roll = random.Next(1, 7);
          return roll;
        }
        
    }
}

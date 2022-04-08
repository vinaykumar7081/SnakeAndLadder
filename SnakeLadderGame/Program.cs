using System;
using SnakeLadderGame;
public class program
{
    public static void Main(String[] args)
    { 
    SnakeGame game = new SnakeGame();
       int start= game.dieRoll();
        Console.WriteLine("Welcome in the Game, You got : "+ start+ "  " +"Position" );
    }
}
using System;

namespace TwentyPlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Game MyGame = new Game();

            MyGame.StartGame();
            MyGame.PlayGame();

            Console.ReadKey();

        }
    }
}

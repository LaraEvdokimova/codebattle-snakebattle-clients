using System;
using SnakeBattle.Api;

namespace Client
{
    class Program
    {
        const string SERVER_ADDRESS = "http://codebattle-pro-2020s1.westeurope.cloudapp.azure.com/codenjoy-contest/board/player/ln5iawtdhaj4jtmsfbbb?code=8362014667098800366
       ";

        static void Main(string[] args)
        {
            var client = new SnakeBattleClient(SERVER_ADDRESS);
            client.Run(DoRun);

            Console.ReadKey();
            client.InitiateExit();
        }

        private static SnakeAction DoRun(GameBoard gameBoard)
        {
            var random = new Random();
            var direction = (Direction)random.Next(Enum.GetValues(typeof(Direction)).Length);
            var act = random.Next() % 2 == 0;
            return new SnakeAction(act, direction);
        }
    }
}

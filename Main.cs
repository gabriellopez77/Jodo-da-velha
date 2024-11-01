using Methods;

namespace Jogo_Da_velha
{
    class JogoDaVelha
    {
        public static char[,] Board = new char[3, 3];
        public static bool GameLoop = true;
        public static bool InputLoop = true;
        public static char Winner = '?';
        public static byte GameStop;

        static void Main()
        {

            GameFunctions.InitializeBoard();
            while(GameLoop)
            {
                GameFunctions.DrawScreen();
                GameFunctions.KeyboardInput();
                GameFunctions.UpdateScreen();
                GameFunctions.CheckSituation();
            }
        } 
    }
}
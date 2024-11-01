using Jogo_Da_velha;

namespace Methods
{
    class GameFunctions
    {
        public static void InitializeBoard()
        {
            byte BoardNum = 0;
            for (byte y = 0; y < 3; y++)
                for (byte x = 0; x < 3; x++)
                {
                    BoardNum++;
                    string Num = Convert.ToString(BoardNum);
                    JogoDaVelha.Board[y,x] = Convert.ToChar(Num);
                }
        }



        public static void DrawScreen()
        {
            for (byte y = 0; y < 3; y++)
            {
                for (byte x = 0; x < 3; x++)
                {
                    Console.Write(JogoDaVelha.Board[y,x]);
                    Console.Write(' ');
                }

                Console.WriteLine();
            }
        }



        public static void KeyboardInput()
        {
            char Turn;
            ConsoleKeyInfo Input;
            
            if (JogoDaVelha.InputLoop)
            {
                Console.Write("Vez do X: ");
                Input = Console.ReadKey();
                JogoDaVelha.InputLoop = false;
                Turn = 'X';
            }

            else
            {
                Console.Write("Vez do O: ");
                Input = Console.ReadKey();
                JogoDaVelha.InputLoop = true;
                Turn = 'O';
            }
            Console.WriteLine();

            char position = Input.KeyChar;
            switch (position)
            {
                case '1':
                if (JogoDaVelha.Board[0,0] != 'X' && JogoDaVelha.Board[0,0] != 'O')
                {
                    JogoDaVelha.Board[0,0] = Turn;
                    JogoDaVelha.GameStop++;
                }
                break;

                case '2':
                if (JogoDaVelha.Board[0,1] != 'X' && JogoDaVelha.Board[0,1] != 'O')
                {
                    JogoDaVelha.Board[0,1] = Turn;
                    JogoDaVelha.GameStop++;
                }
                break;

                case '3':
                if (JogoDaVelha.Board[0,2] != 'X' && JogoDaVelha.Board[0,2] != 'O')
                {
                    JogoDaVelha.Board[0,2] = Turn;
                    JogoDaVelha.GameStop++;
                }
                break;

                case '4':
                if (JogoDaVelha.Board[1,0] != 'X' && JogoDaVelha.Board[1,0] != 'O')
                {
                    JogoDaVelha.Board[1,0] = Turn;
                    JogoDaVelha.GameStop++;
                }
                break;

                case '5':
                if (JogoDaVelha.Board[1,1] != 'X' && JogoDaVelha.Board[1,1] != 'O')
                {
                    JogoDaVelha.Board[1,1] = Turn;
                    JogoDaVelha.GameStop++;
                }
                break;

                case '6':
                if (JogoDaVelha.Board[1,2] != 'X' && JogoDaVelha.Board[1,2] != 'O')
                {
                    JogoDaVelha.Board[1,2] = Turn;
                    JogoDaVelha.GameStop++;
                }
                break;

                case '7':
                if (JogoDaVelha.Board[2,0] != 'X' && JogoDaVelha.Board[2,0] != 'O')
                {
                    JogoDaVelha.Board[2,0] = Turn;
                    JogoDaVelha.GameStop++;
                }
                break;

                case '8':
                if (JogoDaVelha.Board[2,1] != 'X' && JogoDaVelha.Board[2,1] != 'O')
                {
                    JogoDaVelha.Board[2,1] = Turn;
                    JogoDaVelha.GameStop++;
                }
                break;

                case '9':
                if (JogoDaVelha.Board[2,2] != 'X' && JogoDaVelha.Board[2,2] != 'O')
                {
                    JogoDaVelha.Board[2,2] = Turn;
                    JogoDaVelha.GameStop++;
                }
                break;

                default: return;
            }
        }



        public static void CheckSituation()
        {
            if (JogoDaVelha.GameStop == 9 && JogoDaVelha.Winner == '?')
            {
                DrawScreen();
                Console.WriteLine("Empate!");
                JogoDaVelha.GameLoop = false;
            }

            else if
            (
                JogoDaVelha.Board[0,0] == JogoDaVelha.Board[0,1] && JogoDaVelha.Board[0,1] == JogoDaVelha.Board[0,2] && JogoDaVelha.Board[0,2] == 'X' ||
                JogoDaVelha.Board[1,0] == JogoDaVelha.Board[1,1] && JogoDaVelha.Board[1,1] == JogoDaVelha.Board[1,2] && JogoDaVelha.Board[1,2] == 'X' ||
                JogoDaVelha.Board[2,0] == JogoDaVelha.Board[2,1] && JogoDaVelha.Board[2,1] == JogoDaVelha.Board[2,2] && JogoDaVelha.Board[2,2] == 'X' ||

                JogoDaVelha.Board[0,0] == JogoDaVelha.Board[1,0] && JogoDaVelha.Board[1,0] == JogoDaVelha.Board[2,0] && JogoDaVelha.Board[2,0] == 'X' ||
                JogoDaVelha.Board[0,1] == JogoDaVelha.Board[1,1] && JogoDaVelha.Board[1,1] == JogoDaVelha.Board[2,1] && JogoDaVelha.Board[2,1] == 'X' ||
                JogoDaVelha.Board[0,2] == JogoDaVelha.Board[1,2] && JogoDaVelha.Board[1,2] == JogoDaVelha.Board[2,2] && JogoDaVelha.Board[2,2] == 'X' ||

                JogoDaVelha.Board[0,0] == JogoDaVelha.Board[1,1] && JogoDaVelha.Board[1,1] == JogoDaVelha.Board[2,2] && JogoDaVelha.Board[2,2] == 'X' ||

                JogoDaVelha.Board[0,2] == JogoDaVelha.Board[1,1] && JogoDaVelha.Board[1,1] == JogoDaVelha.Board[2,0] && JogoDaVelha.Board[2,0] == 'X'
            )
                JogoDaVelha.Winner = 'X';

            else if
            (
                JogoDaVelha.Board[0,0] == JogoDaVelha.Board[0,1] && JogoDaVelha.Board[0,1] == JogoDaVelha.Board[0,2] && JogoDaVelha.Board[0,2] == 'O' ||
                JogoDaVelha.Board[1,0] == JogoDaVelha.Board[1,1] && JogoDaVelha.Board[1,1] == JogoDaVelha.Board[1,2] && JogoDaVelha.Board[1,2] == 'O' ||
                JogoDaVelha.Board[2,0] == JogoDaVelha.Board[2,1] && JogoDaVelha.Board[2,1] == JogoDaVelha.Board[2,2] && JogoDaVelha.Board[2,2] == 'O' ||

                JogoDaVelha.Board[0,0] == JogoDaVelha.Board[1,0] && JogoDaVelha.Board[1,0] == JogoDaVelha.Board[2,0] && JogoDaVelha.Board[2,0] == 'O' ||
                JogoDaVelha.Board[0,1] == JogoDaVelha.Board[1,1] && JogoDaVelha.Board[1,1] == JogoDaVelha.Board[2,1] && JogoDaVelha.Board[2,1] == 'O' ||
                JogoDaVelha.Board[0,2] == JogoDaVelha.Board[1,2] && JogoDaVelha.Board[1,2] == JogoDaVelha.Board[2,2] && JogoDaVelha.Board[2,2] == 'O' ||

                JogoDaVelha.Board[0,0] == JogoDaVelha.Board[1,1] && JogoDaVelha.Board[1,1] == JogoDaVelha.Board[2,2] && JogoDaVelha.Board[2,2] == 'O' ||

                JogoDaVelha.Board[0,2] == JogoDaVelha.Board[1,1] && JogoDaVelha.Board[1,1] == JogoDaVelha.Board[2,0] && JogoDaVelha.Board[2,0] == 'O'
            )
                JogoDaVelha.Winner = 'O';


            if (JogoDaVelha.Winner != '?')
            {
                DrawScreen();
                Console.WriteLine("{0} venceu o jogo!", JogoDaVelha.Winner);
                JogoDaVelha.GameLoop = false;
            }

        }



        public static void UpdateScreen() => Console.Clear();
    }
}
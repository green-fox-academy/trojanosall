namespace TicTacToe
{
    class GameEngine
    {
        public void StartGame(string[,] TicTacToeBoard)
        {
            var player1 = string.Empty;
            var player2 = string.Empty;

            InitializeBoard(TicTacToeBoard);

            ChoosePlayer(ref player1, ref player2);

            PlayGame(TicTacToeBoard, player1, player2);
        }

        private void InitializeBoard(string[,] ticTacToeBoard)
        {
            ;
        }
    }
}

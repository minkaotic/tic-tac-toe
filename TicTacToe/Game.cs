namespace TicTacToe
{
	public class Game
	{
		public int[,] GameBoard { get; }
		private int _currentPlayer;

		public Game()
		{
			GameBoard = new[,]
			{
				{(int) FieldIs.Empty, (int) FieldIs.Empty, (int) FieldIs.Empty},
				{(int) FieldIs.Empty, (int) FieldIs.Empty, (int) FieldIs.Empty},
				{(int) FieldIs.Empty, (int) FieldIs.Empty, (int) FieldIs.Empty}
			};
			_currentPlayer = 1;
		}

		public void PlayNextTurn(int horizontal, int vertical)
		{
			if (_currentPlayer == 1)
			{
				GameBoard[horizontal, vertical] = (int) FieldIs.X;
				_currentPlayer = 2;
			}
			else
			{
				GameBoard[horizontal, vertical] = (int) FieldIs.O;
				_currentPlayer = 1;
			}
		}
	}
}
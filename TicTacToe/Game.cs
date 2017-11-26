namespace TicTacToe
{
	public class Game
	{
		public Field[,] GameBoard { get; }
		public Player CurrentPlayer { get; private set; }

		public Game()
		{
			GameBoard = new Field[,]
			{
				{Field.Empty, Field.Empty, Field.Empty},
				{Field.Empty, Field.Empty, Field.Empty},
				{Field.Empty, Field.Empty, Field.Empty}
			};
			CurrentPlayer = Player.One;
		}

		public void PlayNextTurn(int horizontal, int vertical)
		{
			if (CurrentPlayer == Player.One)
			{
				GameBoard[horizontal, vertical] = Field.X;
				CurrentPlayer = Player.Two;
			}
			else
			{
				GameBoard[horizontal, vertical] = Field.O;
				CurrentPlayer = Player.One;
			}
		}
	}
}
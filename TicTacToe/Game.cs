namespace TicTacToe
{
	public class Game
	{
		public Field[,] GameBoard { get; }
		public int CurrentPlayer { get; private set; }

		public Game()
		{
			GameBoard = new Field[,]
			{
				{Field.Empty, Field.Empty, Field.Empty},
				{Field.Empty, Field.Empty, Field.Empty},
				{Field.Empty, Field.Empty, Field.Empty}
			};
			CurrentPlayer = 1;
		}

		public void PlayNextTurn(int horizontal, int vertical)
		{
			if (CurrentPlayer == 1)
			{
				GameBoard[horizontal, vertical] = Field.X;
				CurrentPlayer = 2;
			}
			else
			{
				GameBoard[horizontal, vertical] = Field.O;
				CurrentPlayer = 1;
			}
		}
	}
}
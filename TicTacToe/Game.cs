namespace TicTacToe
{
	public class Game
	{
		public int[,] GameBoard { get; }

		public Game()
		{
			GameBoard = new[,]
			{
				{ (int)FieldIs.Empty, (int)FieldIs.Empty, (int)FieldIs.Empty },
				{ (int)FieldIs.Empty, (int)FieldIs.Empty, (int)FieldIs.Empty },
				{ (int)FieldIs.Empty, (int)FieldIs.Empty, (int)FieldIs.Empty }
			};
		}

		public void PlayNextTurn(int horizontal, int vertical)
		{
			GameBoard[2,2] = (int)FieldIs.X;
		}
	}
}
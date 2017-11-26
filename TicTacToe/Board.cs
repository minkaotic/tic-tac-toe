namespace TicTacToe
{
	public class Board
	{
		public Field[,] Matrix { get; private set; }

		public Board()
		{
			Matrix = new[,]
			{
				{Field.Empty, Field.Empty, Field.Empty},
				{Field.Empty, Field.Empty, Field.Empty},
				{Field.Empty, Field.Empty, Field.Empty}
			};
		}

		public void UpdateBoard(int horizontal, int vertical, Field token)
		{
			Matrix[horizontal, vertical] = token;
		}
	}
}
namespace TicTacToe
{
	public class Board
	{
		//Todo: make board immutable and return a new one on update
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

		public Field TokenAt(int horizontal, int vertical)
		{
			return Matrix[horizontal, vertical];
		}
	}
}
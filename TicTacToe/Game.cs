namespace TicTacToe
{
	public class Game
	{
		public int[,] GameBoard { get; set; }

		public Game()
		{
			const int empty = 0;
			GameBoard = new[,] {{empty, empty, empty}, {empty, empty, empty}, {empty, empty, empty}};
		}
	}
}
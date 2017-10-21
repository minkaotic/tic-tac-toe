namespace TicTacToe
{
	public class Game
	{
		public int[,] GameBoard { get; set; }

		public Game()
		{
			GameBoard = new[,] {{0, 0, 0}, {0, 0, 0}, {0, 0, 0}};
		}
	}
}
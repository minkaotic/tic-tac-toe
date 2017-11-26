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
			GameBoard[horizontal, vertical] = CurrentPlayerToken();
			CurrentPlayer = NextPlayer();
		}

		private Field CurrentPlayerToken()
		{
			return CurrentPlayer == Player.One ? Field.X : Field.O;
		}

		private Player NextPlayer()
		{
			return CurrentPlayer == Player.One ? Player.Two : Player.One;
		}
	}
}
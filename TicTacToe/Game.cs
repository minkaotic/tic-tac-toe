using System;

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
			if (GameBoard[horizontal, vertical] != Field.Empty)
			{
				throw new FieldAlreadyUsedException("Field has already been claimed in a previous move");
			}

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

	public class FieldAlreadyUsedException : Exception
	{
		public FieldAlreadyUsedException(string message) : base(message) { }
	}
}
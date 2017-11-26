using System;

namespace TicTacToe
{
	public class Game
	{
		//TODO: refactor board to be private field
		//and only expose things needed (move existing
		//board-related tests to separate unit test)
		public Board Board { get; }
		public Player CurrentPlayer { get; private set; }

		public Game(Board board)
		{
			Board = board;
			CurrentPlayer = Player.One;
		}

		public void PlayNextTurn(int horizontal, int vertical)
		{
			if (Board.Matrix[horizontal, vertical] != Field.Empty)
			{
				throw new FieldAlreadyUsedException("Field has already been claimed in a previous move");
			}

			var currentPlayerToken = CurrentPlayer == Player.One ? Field.X : Field.O;
			Board.UpdateBoard(horizontal, vertical, currentPlayerToken);
			CurrentPlayer = NextPlayer();
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
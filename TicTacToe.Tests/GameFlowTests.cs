using NUnit.Framework;

namespace TicTacToe.Tests
{
	[TestFixture]
	public class GameFlowTests
	{
		/* TODO: Things to test:
		 * 1. It can represent a 3x3 empty game board
		 * 2. It persists one player's moves (x)
		 * 3. It persists other player's moves (0)
		 * 4. A token cannot be placed in a field that already has a token
		 * 5. 3 in a row is a win
		 * 6. A full board without 3 in a row ends game in draw
		 */

		[Test]
		public void Represents_a_3_by_3_game_board()
		{
			var game = new Game();

			Assert.That(game.GameBoard.Length, Is.EqualTo(9));
			Assert.That(game.GameBoard.Rank, Is.EqualTo(2));
			Assert.That(game.GameBoard.GetUpperBound(0), Is.EqualTo(2));
			Assert.That(game.GameBoard.GetUpperBound(1), Is.EqualTo(2));
		}
	}
}
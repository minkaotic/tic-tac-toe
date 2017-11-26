using NUnit.Framework;

namespace TicTacToe.Tests
{
	[TestFixture]
	public class GameFlowTests
	{
		private Game _game;

		[SetUp]
		public void Setup()
		{
			_game = new Game();
		}

		/* TODO: Things to test:
		Returns currently active player
		A token cannot be placed in a field that already has a token
		3 in a row is a win
		A full board without 3 in a row ends game in draw
		*/

		[Test]
		public void Represents_a_two_dimensional_game_board_with_nine_fields()
		{
			Assert.That(_game.GameBoard.Length, Is.EqualTo(9));
			Assert.That(_game.GameBoard.Rank, Is.EqualTo(2));
			AssertThatEachDimensionHasThreeFields();
		}

		[Test]
		public void Stores_player_moves_alternately()
		{
			_game.PlayNextTurn(2, 2);
			Assert.That(_game.GameBoard[2,2], Is.EqualTo((int)FieldIs.X));

			_game.PlayNextTurn(2, 1);
			Assert.That(_game.GameBoard[2,1], Is.EqualTo((int)FieldIs.O));

			_game.PlayNextTurn(1, 2);
			Assert.That(_game.GameBoard[1, 2], Is.EqualTo((int)FieldIs.X));

			_game.PlayNextTurn(0, 2);
			Assert.That(_game.GameBoard[0, 2], Is.EqualTo((int)FieldIs.O));
		}

		private void AssertThatEachDimensionHasThreeFields()
		{
			const int firstDimension = 0;
			const int secondDimension = 1;
			const int indexOfThirdElement = 2;
			Assert.That(_game.GameBoard.GetUpperBound(firstDimension), Is.EqualTo(indexOfThirdElement));
			Assert.That(_game.GameBoard.GetUpperBound(secondDimension), Is.EqualTo(indexOfThirdElement));
		}
	}
}
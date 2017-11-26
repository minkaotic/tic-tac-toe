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
			var board = new Board();
			_game = new Game(board);
		}

		/* TODO: Things to test:
		3 in a row is a win
		A full board without 3 in a row ends game in draw
		*/

		[Test]
		public void Represents_a_two_dimensional_game_board_with_nine_fields()
		{
			Assert.That(_game.Board.Matrix.Length, Is.EqualTo(9));
			Assert.That(_game.Board.Matrix.Rank, Is.EqualTo(2));
			AssertThatEachDimensionHasThreeFields();
		}

		[Test]
		public void Stores_player_moves_alternately()
		{
			_game.PlayNextTurn(2, 2);
			Assert.That(_game.Board.Matrix[2,2], Is.EqualTo(Field.X));

			_game.PlayNextTurn(2, 1);
			Assert.That(_game.Board.Matrix[2,1], Is.EqualTo(Field.O));

			_game.PlayNextTurn(1, 2);
			Assert.That(_game.Board.Matrix[1, 2], Is.EqualTo(Field.X));

			_game.PlayNextTurn(0, 2);
			Assert.That(_game.Board.Matrix[0, 2], Is.EqualTo(Field.O));
		}

		[Test]
		public void Returns_currently_active_player()
		{
			Assert.That(_game.CurrentPlayer, Is.EqualTo(Player.One));

			_game.PlayNextTurn(2, 2);
			Assert.That(_game.CurrentPlayer, Is.EqualTo(Player.Two));

			_game.PlayNextTurn(2, 1);
			Assert.That(_game.CurrentPlayer, Is.EqualTo(Player.One));
		}

		[Test]
		public void Three_X_in_a_row_means_player_one_has_won()
		{
			_game.PlayNextTurn(2, 2);
			_game.PlayNextTurn(2, 1);
			_game.PlayNextTurn(1, 2);
			_game.PlayNextTurn(1, 1);
			_game.PlayNextTurn(0, 2);
		}

		[Test]
		public void Throws_if_token_is_placed_in_non_empty_field()
		{
			_game.PlayNextTurn(2, 2);
			var exception = Assert.Throws<FieldAlreadyUsedException>(() => { _game.PlayNextTurn(2, 2); });
			Assert.That(exception.Message, Is.EqualTo("Field has already been claimed in a previous move"));
		}

		private void AssertThatEachDimensionHasThreeFields()
		{
			const int firstDimension = 0;
			const int secondDimension = 1;
			const int indexOfThirdElement = 2;
			Assert.That(_game.Board.Matrix.GetUpperBound(firstDimension), Is.EqualTo(indexOfThirdElement));
			Assert.That(_game.Board.Matrix.GetUpperBound(secondDimension), Is.EqualTo(indexOfThirdElement));
		}
	}
}
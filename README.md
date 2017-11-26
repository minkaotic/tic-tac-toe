# Tic-Tac-Toe
Code kata using TDD, to explore C# multi-dimensional arrays and enums.

### Approach 
Following a strict red->green->refactor loop, I am breaking requirements down into the following testables:

- Initial game represents a 3x3 empty game board
- First player's moves are persisted (x)
- Second player's moves are persisted (0)
- Players (and thus token types) draws are strictly alternated
- Returns currently active player
- A token cannot be placed in a field that already has a token
- 3 in a row is a win
- A full board without 3 in a row ends game in draw

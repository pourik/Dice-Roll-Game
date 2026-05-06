using DiceRollGame.Game;

Random random = new();
DiceRoll diceRoll = new(random);
GuessingGame guessingGame = new(diceRoll);

GameResult result = guessingGame.Play();
GuessingGame.PrintGameResult(result);

Console.ReadKey();


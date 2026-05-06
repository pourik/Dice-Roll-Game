using DiceRollGame.UserCommunication;

namespace DiceRollGame.Game;

class GuessingGame
{
    private readonly DiceRoll _diceRoll;
    private const int NumberOfGuesses = 3;

    public GuessingGame(DiceRoll diceRoll)
    {
        _diceRoll = diceRoll;
    }

    public GameResult Play()
    {
        var diceRollResult = _diceRoll.Roll();
        Console.WriteLine($"Dice rolled. Guess what number it shows in {NumberOfGuesses} tries.");

        var guessesLeft = NumberOfGuesses;
        while (guessesLeft > 0)
        {
            var guess = ConsoleReader.ReadNumber("Enter your guess: ");
            if(guess == diceRollResult)
            {
                return GameResult.Victory;
            }
            Console.WriteLine("Wrong Guess lol!");
            guessesLeft--;
        }
        return GameResult.Defeat;
    }

    public static void PrintGameResult(GameResult result)
    {
        string message = result == GameResult.Victory ? "You won! :)" : "You lost! XD";
        Console.WriteLine(message);
    }
}


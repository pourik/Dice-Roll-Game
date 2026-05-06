namespace DiceRollGame.Game;

class DiceRoll
{
    private readonly Random _random;
    private readonly int _sidesCount = 6;

    public DiceRoll(Random random)
    {
        _random = random;
    }

    public int Roll() => _random.Next(1, _sidesCount + 1);
}
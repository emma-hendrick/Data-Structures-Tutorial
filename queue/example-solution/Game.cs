namespace cards;

internal class Game
{
    private int _lastDraw = -1;
    private int _currentDraw = -1;
    private Deck _deck = new Deck();
    private int _score = 0;

    public void Play()
    {
        Console.WriteLine("Welcome to Hi-Lo!");
        Console.WriteLine("When you reach the guessing phase, you can enter q to quit.");

        while (true)
        {
            if (_lastDraw == -1) 
            {
                _lastDraw = _deck.DrawCard();
            }

            string? response = null;

            while (response != "h" && response != "l")
            {
                Console.WriteLine($"Will the next card be higher or lower than {_lastDraw} (h/l)? ");
                response = Console.ReadLine();
                if (response == "q") return;
            }

            _currentDraw = _deck.DrawCard();
            _score += ((response == "h") == (_currentDraw > _lastDraw)) ? 75: -100;

            Console.WriteLine($"You drew a {_currentDraw}! Score: {_score}");

            _lastDraw = _currentDraw;
        }
    }
}
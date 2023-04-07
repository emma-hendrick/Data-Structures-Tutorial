namespace cards;

internal class Deck
{
    private static Random rng = new Random();
    private Queue<int> _cards = new Queue<int>();

    public Deck()
    {
        Shuffle();
    }

    private void Shuffle()
    {
        Console.WriteLine("Shuffling...");
        List<int> cardsToShuffle = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};
        List<int> shuffledCards = cardsToShuffle.OrderBy(i => rng.Next()).ToList();;
        
        foreach (int card in shuffledCards)
        {
            _cards.Enqueue(card);
        }
    }

    public int DrawCard()
    {
        if (_cards.Count() == 0) Shuffle();
        return _cards.Dequeue();
    }

}
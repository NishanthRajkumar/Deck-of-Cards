namespace DeckOfCards;

internal class CardDeck
{
    // List of Card objects in the CardDeck
    private readonly List<Card> cards;

    /// <summary>
    /// Initializes a new instance of the <see cref="CardDeck"/> class.
    /// </summary>
    public CardDeck()
    {
        cards = new();
        Reset();
    }

    /// <summary>
    /// Resets the deck.
    /// </summary>
    public void Reset()
    {
        cards.Clear();
        foreach (Card.Suit suit in Enum.GetValues(typeof(Card.Suit)))
            foreach (Card.Rank rank in Enum.GetValues(typeof(Card.Rank)))
                cards.Add(new Card(suit, rank));
    }

    /// <summary>
    /// Removes card from deck and returns that card.
    /// </summary>
    /// <param name="index">The index.</param>
    /// <returns>A card from the deck</returns>
    public Card GetCard(int index)
    {
        Card tempCard = new(cards[index].suit, cards[index].rank);
        cards.RemoveAt(index);
        return tempCard;
    }
}

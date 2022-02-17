namespace DeckOfCards;

internal class CardDeck
{
    private static readonly List<Card> cards;

    static CardDeck()
    {
        cards = new();
        Reset();
    }

    public static void Reset()
    {
        cards.Clear();
        foreach (Card.Suit suit in Enum.GetValues(typeof(Card.Suit)))
            foreach (Card.Rank rank in Enum.GetValues(typeof(Card.Rank)))
                cards.Add(new Card(suit, rank));
    }

    public static Card GetCard(int index)
    {
        Card tempCard = new(cards[index].suit, cards[index].rank);
        cards.RemoveAt(index);
        return tempCard;
    }
}

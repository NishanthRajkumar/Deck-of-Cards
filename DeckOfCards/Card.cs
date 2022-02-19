using GenericQueue;

namespace DeckOfCards;

/// <summary>
/// Encapsulates the details of each card
/// </summary>
/// <seealso cref="GenericQueue.IQueueListComparable&lt;DeckOfCards.Card&gt;" />
internal class Card : IQueueListComparable<Card>
{
    // The card suit and rank attributes
    public readonly Suit suit;
    public readonly Rank rank;

    // Enum for card suit
    public enum Suit
    {
        Club, Diamond, Heart, Spade
    }

    // Enum for card rank
    public enum Rank
    {
        _2, _3, _4, _5, _6, _7, _8, _9, _10, Jack, Queen, King, Ace
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Card"/> class.
    /// </summary>
    public Card()
    {
        this.suit = Suit.Club;
        this.rank = Rank._2;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Card"/> class using card suit and rank as parameters
    /// </summary>
    public Card(Suit suit, Rank rank)
    {
        this.suit = suit;
        this.rank = rank;
    }

    /// <summary>
    /// Gets the card information.
    /// </summary>
    /// <returns>A string containing card suit & rank info</returns>
    public string GetCardInfo()
    {
        return $"{suit} {rank}";
    }

    /// <summary>
    /// Compares the rank of the card with the calling card object.
    /// </summary>
    /// <param name="card">The card to be compared.</param>
    /// <returns></returns>
    public int CompareRank(Card card)
    {
        if (rank > card.rank)
            return 1;
        else if (rank < card.rank)
            return -1;
        else
            return 0;
    }

    /// <summary>
    /// Determines whether the specified card is equal.
    /// </summary>
    /// <param name="card">The card.</param>
    /// <returns>
    ///   <c>true</c> if the specified card is equals; otherwise, <c>false</c>.
    /// </returns>
    public bool IsEquals(Card card)
    {
        if (suit == card.suit && rank == card.rank)
            return true;
        return false;
    }

    // Overriding the ToString method of object class
    public override string ToString()
    {
        return $"{suit} {rank}";
    }
}

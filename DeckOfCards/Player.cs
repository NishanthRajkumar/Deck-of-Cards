using GenericQueue;

namespace DeckOfCards;

/// <summary>
/// Player class holds details of each player
/// </summary>
/// <seealso cref="GenericQueue.IQueueListComparable&lt;DeckOfCards.Player&gt;" />
internal class Player : IQueueListComparable<Player>
{
    // Player id and cards list attributes declaration
    private readonly QueueList<Card> cards;
    private readonly int playerId;

    /// <summary>
    /// Initializes a new instance of the <see cref="Player"/> class.
    /// </summary>
    /// <param name="id">The player id.</param>
    public Player(int id)
    {
        cards = new QueueList<Card>();
        playerId = id;
    }

    /// <summary>
    /// Sorts the list of cards based on Card Rank.
    /// </summary>
    /// <param name="cardList">The card list.</param>
    public void RankSort(QueueList<Card> cardList)
    {
        Card highCard = new Card();
        Card tempCard;
        QueueList<Card> tempList = new QueueList<Card>();
        do
        {
            tempCard = cardList.GetNodeFromQueue();
            tempList.Enqueue(tempCard);
            if (tempCard != null && highCard.CompareRank(tempCard) <= 0)
                highCard = tempCard;
            if (cardList.head == null && tempList.head != null)
            {
                cardList = tempList;
                tempList = new QueueList<Card>();
                cards.Enqueue(highCard);
                cardList.Remove(highCard);
                highCard = new Card();
            }
        } while (cardList.head != null);
    }

    /// <summary>
    /// Determines whether the specified player is equal to the Player object calling this method.
    /// </summary>
    /// <param name="player">The player.</param>
    /// <returns>
    ///   <c>true</c> if the specified player is equal; otherwise, <c>false</c>.
    /// </returns>
    public bool IsEquals(Player player)
    {
        if (playerId == player.playerId)
            return true;
        return false;
    }

    // Overriding the ToString method of object class
    public override string ToString()
    {
        return $"Player {playerId} Cards in hand:\n{cards}";
    }
}

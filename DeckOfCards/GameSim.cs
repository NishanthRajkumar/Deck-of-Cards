using GenericQueue;

namespace DeckOfCards;

/// <summary>
/// Game simulation class
/// </summary>
internal class GameSim
{
    // GameSim Attributes declaration
    private readonly QueueList<Player> players;         // List of players
    private readonly CardDeck deck;                     // A Deck of cards

    /// <summary>
    /// Initializes a new instance of the <see cref="GameSim"/> class.
    /// </summary>
    public GameSim()
    {
        players = new QueueList<Player>();
        deck = new CardDeck();
    }

    /// <summary>
    /// Distributes the cards after random shuffle.
    /// </summary>
    public void Distribute()
    {
        int shuffle;
        Random rand = new();
        int upperBound = 52;
        for (int i = 0; i < 4; i++)
        {
            QueueList<Card> playerCards = new QueueList<Card>();
            Player player = new Player(i + 1);
            for (int j = 0; j < 9; j++)
            {
                shuffle = rand.Next(0, upperBound--);
                Card card = deck.GetCard(shuffle);
                playerCards.Enqueue(card);
                deck.RemoveFromDeck(card);
            }
            player.RankSort(playerCards);
            players.Enqueue(player);
        }
    }

    /// <summary>
    /// Displays the cards of all players
    /// </summary>
    public void Display()
    {
        Console.WriteLine("Player Details:");
        Console.WriteLine(players);
    }
}

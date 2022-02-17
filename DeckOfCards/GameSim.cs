namespace DeckOfCards;

internal class GameSim
{
    // Card array for 4 player and 9 cards each
    private readonly Card[,] playerCards;
    private readonly CardDeck deck;

    /// <summary>
    /// Initializes a new instance of the <see cref="GameSim"/> class.
    /// </summary>
    public GameSim()
    {
        playerCards = new Card[4, 9];
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
            for (int j = 0; j < 9; j++)
            {
                shuffle = rand.Next(0, upperBound--);
                playerCards[i, j] = deck.GetCard(shuffle);
            }
    }

    /// <summary>
    /// Displays the cards of all players
    /// </summary>
    public void Display()
    {
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"\nPlayer {i + 1}:");
            for (int j = 0; j < 9; j++)
                Console.WriteLine($"Card {j + 1}: " + playerCards[i, j].GetCardInfo());
        }
    }
}

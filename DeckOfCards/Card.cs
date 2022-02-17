namespace DeckOfCards
{
    internal class Card
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
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="suit">The card suit.</param>
        /// <param name="rank">The card rank.</param>
        public Card(Suit suit, Rank rank)
        {
            this.suit = suit;
            this.rank = rank;
        }

        public string GetCardInfo()
        {
            return $"{suit} {rank}";
        }
    }
}

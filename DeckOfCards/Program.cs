using DeckOfCards;

Console.Title = "Deck of Cards";
Console.WriteLine("----------Deck of Cards----------");

// Testing the project features
GameSim game = new();
game.Distribute();
game.Display();

Console.ReadKey();
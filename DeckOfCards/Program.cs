using DeckOfCards;

Console.Title = "Deck of Cards";
Console.WriteLine("----------Deck of Cards----------");

GameSim game = new();

game.Distribute();

game.Display();

Console.ReadKey();
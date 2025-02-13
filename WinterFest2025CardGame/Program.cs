using WinterFest2025CardGame;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Deck deckOfCards = new Deck();

Console.WriteLine("Welcome to the game!");
Console.Write("Enter Player name: ");
Player firstPlayer = new Player(Console.ReadLine()!);

// deal the first player five cards
for (int i = 0; i < 5; i++)
{
    firstPlayer.Hand.Add(deckOfCards.DealCard());
}

firstPlayer.ShowHand();



//// display all of cards in deck
//foreach (Card card in deckOfCards.Cards)
//{
//    Console.Write($"{card} ");
//}



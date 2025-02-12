using WinterFest2025CardGame;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Deck deckOfCards = new Deck();

foreach (Card card in deckOfCards.Cards)
{
    Console.Write($"{card} ");
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterFest2025CardGame;

public class Deck
{
    public List<Card> Cards { get; set; } = new List<Card>();

    public Deck()
    {
        // 52 cards total.  four suits ♥, ♦, ♣, ♠ and 13 cards in each suit 2-10, j, q, k, a
        List<string> suits = new List<string>() { "♥", "♦", "♣", "♠" };
        List<string> ranks = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        List<int> values = new List<int>() { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

        foreach (string suit in suits)
        {
            foreach (string rank in ranks)
            {
                Card card = new Card(suit, values[ranks.IndexOf(rank)], rank);
                Cards.Add(card);
            }
        }
    }

    // deal card method
    // randomly pick a card from the deck and return that card
    public Card DealCard()
    {
        Random rnd = new Random();
        // with random get a random number between 0 and 51
        int cardToDealIndex = rnd.Next(Cards.Count);
        // get the card, then remove that card from the deck, then return that card after removing
        Card cardtoDeal = Cards[cardToDealIndex];
        Cards.Remove(cardtoDeal);
        return cardtoDeal;
    }

}

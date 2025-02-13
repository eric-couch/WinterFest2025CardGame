using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WinterFest2025CardGame;

public class FiveCardDraw
{
    // methods that determine what hand the player(s) have

    // check for ace in hand
    public static bool HasAce(List<Card> cards)
    {
        // linq query to determine if cards has Ace
        bool results = (from card in cards
                        where card.value == 14
                        select card).Count() > 0;

        //bool results = cards.Select(card => card.value).Contains(14);

        //bool results = cards.Any(card => card.rank == "A");

        return results;
    }

    // find highest card

    // check for pair.  is there a pair of cards?
    public static bool HasPair(List<Card> cards)
    {
        // are there exactly two rank/values that are the same
        // select count(*) from cards group by cards.rank having count(*) = 2

        //var results = cards.GroupBy(card => card.value);
        //bool HasPair = results.Any(group => group.Count() == 2);
        
        bool hasPair = cards.GroupBy(card => card.rank)
                            .Any(group => group.Count() == 2);

        return hasPair;
    }

    public static bool HasTrips(List<Card> cards)
    {
        bool hasPair = cards.GroupBy(card => card.rank)
                            .Any(group => group.Count() == 3);

        return hasPair;
    }

    public static bool IsFullHouse(List<Card> cards)
    {
        return HasTrips(cards) && HasPair(cards);
    }

    public static bool IsStraight(List<Card> cards)
    {
        var sortedCards = cards.OrderBy(c => c.value)
                                .Select(c => c.value).ToList();
        // 4, 5, 6, 7, 8
        return sortedCards.Zip(sortedCards.Skip(1), (a, b) => b - a).All(x => x == 1);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterFest2025CardGame;

public class Card
{
    public string suit { get; set; }    // ♥, ♦, ♣, ♠  <- alt + numpad 3, 4, 5, 6
    public int value { get; set; }      // 2, 3, 4... 10, 11, 12, 13, 14
    public string rank { get; set; }    // 2, 3, 4... 10, J, Q, K, A

    /// <summary>
    /// Creates a single playing card.  For Example: Ace of Spades (A♠)
    /// </summary>
    /// <param name="suit">♥, ♦, ♣, ♠</param>
    /// <param name="value">2, 3, 4... 10, 11, 12, 13, 14</param>
    /// <param name="rank">2, 3, 4... 10, J, Q, K, A</param>
    public Card(string suit, int value, string rank)
    {
        this.suit = suit;
        this.value = value;
        this.rank = rank;
    }

    public override string? ToString()
    {
        return $"{rank}{suit}";
    }
}

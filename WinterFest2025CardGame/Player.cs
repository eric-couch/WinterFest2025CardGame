using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterFest2025CardGame;

public class Player
{
    public string Name { get; set; }
    public List<Card> Hand { get; set; }

    // get a card

    // show hand
    public void ShowHand()
    {
        foreach (Card card in Hand)
        {
            Console.WriteLine(card);
        }
    }
}

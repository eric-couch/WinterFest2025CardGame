using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterFest2025CardGame;

public class Player
{
    public string Name { get; set; }
    public List<Card> Hand { get; set; } = new List<Card>();

    public Player(string Name)
    {
        this.Name = Name;
    }

    // get a card

    // show hand
    public void ShowHand()
    {
        foreach (Card card in Hand)
        {
            Console.Write($"{card}\t");
        }
    }
}

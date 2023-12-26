using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Programm
    {
        static void Main()
        {
            int userInput;
            Utils utils = new Utils();
            Deck deck = new Deck();
            List<Card> userHand = new List<Card>();
            List<Card> drillerHand = new List<Card>();
            deck.FillTheDeck();
            int userPoint;
            int drillerPoint;

            do
            {
                userHand.Add(deck.GetRandomCard());
                drillerHand.Add(deck.GetRandomCard());
                userHand.Add(deck.GetRandomCard());
                drillerHand.Add(deck.GetRandomCard());
                userInput = utils.GetNumber();
                switch (userInput)
                {
                    case (int)PlayerAction.TakeMore:
                        break;

                    case (int)PlayerAction.Pass:
                        break;

                    default:
                        break;
                }
            } while (userInput != (int)PlayerAction.Pass);
        }
    }
}

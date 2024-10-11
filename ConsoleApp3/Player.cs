using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame
{
    internal class Player
    {
        public string name;
        public Card[] hand = new Card[2];
        public Card stronguestCard;
        public int score = 0;
        Deck deck;


        public Player(string aName, Deck adeck)
        {
            name = aName;
            deck = adeck;
        }

        public void setHand()
        {
            hand[0] = deck.drawCard();
            hand[1] = deck.drawCard();

            Console.WriteLine(name + " draw:");
            Console.WriteLine("First Card\n");
            hand[0].prettyPrint();
            Console.WriteLine("\n");
            Console.WriteLine("Second Card\n");
            hand[1].prettyPrint();
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------------------");
            strongCard();
        }

        //public void printHand()
        //{
        //    hand[0].prettyPrint();
        //    hand[1].prettyPrint();
        //}

        public void strongCard()
        {
            if (hand[0].numberValue > hand[1].numberValue)
            {
                stronguestCard = hand[0];
            }

            else if (hand[0].numberValue < hand[1].numberValue)
            {
                stronguestCard = hand[1];
            }
            else 
            {
                if (hand[0].suitValue > hand[1].suitValue)
                {
                    stronguestCard = hand[0];
                }
                else if (hand[0].suitValue < hand[1].suitValue)
                {
                    stronguestCard = hand[1];
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Deck
    {
        public List<Card> cardsList = new List<Card>();
        public Card[] cards;
        public int drawIndex = 51;

        public Deck()
        {
            var rand = new Random();
            createDeck();      
            Shuffle(rand, cards);
            Shuffle(rand, cards);   
            
        }

        public void createDeck()
        {
            for (int i = 0; i < 13; i++)
            {
                cardsList.Add(new Card("Espadas", i + 2));
                cardsList.Add(new Card("Copas", i + 2));
                cardsList.Add(new Card("Ouros", i + 2));
                cardsList.Add(new Card("Paus", i + 2));
            }
            cards = cardsList.ToArray();
        }



        public void Shuffle<T>(Random random, T[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                int k = random.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }

        public Card drawCard()
        {
            Card takenCard;
            if (drawIndex > 0)
            {
                takenCard = cards[drawIndex];
                drawIndex--;
                
            }
            else
            {
                takenCard = cards[0];
            }
            return takenCard;
        }
    }
}
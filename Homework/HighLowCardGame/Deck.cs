using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowCardGame
{
    class Deck
    {
        public List<Card> Cards;

        //public int[,] cards = new int[4,13];

        public Deck()
        {
            Cards = new List<Card>();
        }

        public Deck(int pValue = 13, int pSuit = 4) : this()
        {

            for (int i = 0; i < pValue; i++)
            {
                for (int j = 0; j < pSuit; j++)
                {
                    Cards.Add(new Card { Value = i + 1, Suit = j + 1 });
                    //Console.WriteLine("Added new card (value = " + i + ", suit = " + j + ") to the list.");
                }
            }
        }

        public void Shuffle()//(List<T> pDeck)
        {
            Random random = new Random();
            for (int i = 0; i < Cards.Count; i++)
            {
                var j = random.Next(i, Cards.Count); // Don't select from the entire pDeck on subsequent loops
                var temp = Cards[i];
                Cards[i] = Cards[j];
                Cards[j] = temp;
            }
            //Console.WriteLine("[Shuffle] Done.");
        }

        public void ViewCardsinDeck()
        {
            foreach (Card aCard in this.Cards)
            {
                Console.WriteLine(aCard);
            }
        }
    }
}
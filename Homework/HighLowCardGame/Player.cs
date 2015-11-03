using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowCardGame
{
    class Player
    {
        private Deck _playingdeck;
        private int _count;
        private string _name;
        private int order = 0;

        public Deck PlayingDeck
        {
            get;
            set;
        }
        public int Count
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public int Order
        {
            get;
            set;
        }

        public Player(int pOrder = 0, string pName = "Anonymous")
        {
            PlayingDeck = new Deck();
            Count = 0;
            Name = pName;
            Order = pOrder;
        }

        public void ShowPlayerProperties()
        {
            Console.WriteLine("[" + Name + "] has | " + PlayingDeck.Cards.Count + " playing card(s) |, | " + Count + " winning card(s) |");
        }
    }
}
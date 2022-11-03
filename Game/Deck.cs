using System;
using System.Collections.Generic;
using System.Linq;

namespace cse210_02.Game

{
    class Deck
    {
        private List<int> deck = new List<int>();
        public int cardDrawn;
        private int[] shuffledDeck;
        private int cardIndex = 0;
        
        public Deck()
        {
            for (int i = 1; i <= 13; i++)
            {
                deck.Add(i);
                deck.Add(i);
                deck.Add(i);
                deck.Add(i);
            }
        }
        
        public List<int> Shuffle()
        {
            Random r = new Random();
            return deck.OrderBy(x => r.Next()).ToList();  
        }
        
        /// draw a card
        public int Draw()
        {
            cardDrawn = shuffledDeck[cardIndex];
            cardIndex++;
            if (cardIndex == 52)
            {
                Shuffle();
                cardIndex = 0;
            }
            return cardDrawn;
        }
        
        public void reset()
        {
            cardIndex = 0;
        }
    }
}

using System;
using System.Collections.Generic;

namespace cse210_02.Game

{
    class Director
    {

        Deck deck = new Deck();
        bool _isPlaying = true;
        int _score = 300;   

        string highLow = "-";     
        

        public Director()
        {
            Console.WriteLine("Welcome to a game of Hilo!");
            Console.WriteLine("You will be given a card, and you must guess if the next card will be higher or lower.");
            Console.WriteLine("If you guess correctly, you earn 100 points. If you guess incorrectly, you lose the 75 points.");
            Console.WriteLine("The game ends when you hit 0 points or decide to quit playing.");
            Console.WriteLine("Good luck!");

            
            deck.Shuffle();
        }

        public void StartGame()
        {
            while(_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        public void GetInputs()
        {
            Console.WriteLine("Draw a Card? (y/n)");
            string confirmDrawCard = Console.ReadLine();
            _isPlaying = (confirmDrawCard == "y");

            if(_isPlaying)
            {
                Console.WriteLine("Your card is: " + deck.cardDrawn);
                Console.WriteLine("will the next card be higher or lower? (h/l)");
                highLow = Console.ReadLine();
            }
        }

        public void DoUpdates()
        {
            if(!_isPlaying)
            {
                return;
            }


            int lastCard = deck.cardDrawn;
            deck.Draw();
            int currentCard = deck.cardDrawn;

            if(highLow == "h")
            {
                if(currentCard > lastCard)
                {
                    _score += 100;
                }
                else if(currentCard < lastCard)
                {
                    _score -= 75;
                }
            }
            else if(highLow == "l")
            {
                if(lastCard > currentCard)
                {
                    _score += 100;
                }
                else if(lastCard < currentCard)
                {
                    _score -= 75;
                }
            }

        }

        public void DoOutputs()
        {
            if(!_isPlaying)
            {
                return;
            }

            Console.WriteLine($"you drew: {deck.cardDrawn}\n");
            Console.WriteLine($"Your score is: {_score}\n");
            _isPlaying = (_score >= 0);
        }
        
    }
}

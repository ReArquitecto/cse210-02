# CSE210-02
Repo for our CSE210 games

contains a Deck class that stores a list of values between 1 and 13

    contains a draw card function
    
    contains a shuffle function
    
    contains draw position variable to go through the list and draw the next card
    ----------------------------------------------------------------------------------

contains a Director class that runs through the game

    contains a start game function which gets the inputs, does updates, and does outputs until the game is over
    
    contains a get inputs function which decides if the player wants to continue playing, if not game is over
    
    contains a do updates function which will get an input if the player wants higher or lower
        then compares last card to current card and adds or subtract points
        
    contains do outputs which displays what you drew and displays your new score, if score is 0 game is over 

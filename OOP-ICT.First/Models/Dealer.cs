using OOP_ICT.Interfaces;

namespace OOP_ICT;

public class Dealer 
{
    CardDeck DealerDeck = new CardDeck();
    
    public void Shuffle()
    {
        DealerDeck.Shuffle();
    }
    public UserDeck CreateShuffledUserDeck(int numCards)
    {
        UserDeck userDeck = new UserDeck();
        for (int i = 0; i < numCards; i++)
        {
            userDeck.AddCard(DealerDeck.Draw());
        }
        userDeck.Shuffle();
        return userDeck;
    }

}
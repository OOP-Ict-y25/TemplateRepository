using OOP_ICT.Interfaces;

namespace OOP_ICT.Models;

public class Dealer : IDealer
{
    private List<Card> userDeck;
    public void InitializeCardDeck()
    {
        userDeck = CardDeck.Create();
    }

    public UserDeck CreateShuffledUserDeck()
    {
        var newUserDeck = PerfectShuffle(userDeck);
        
        return new UserDeck(newUserDeck);
    }
    public static List<Card> PerfectShuffle(List<Card> cards){
        var half=cards.Count/2;
        Card[] temp = new Card[cards.Count];
        for(int i = 0; i < half; i++)
        {
            temp[i*2]=cards[i+half];
            temp[i*2+1]=cards[i];
        }
        return temp.ToList();
    }
}
using System.Security.Cryptography.X509Certificates;

namespace OOP_ICT.Models;

public class Dealer : IDealer
{
    private CardDeck deck;

    public Dealer(CardDeck originalDeck)
    {
        deck = originalDeck;
    }

    public CardDeck ShowOriginal()
    {
        return deck;
    }

    public CardDeck GetShuffledUseDeck()
    {
        deck.Shuffle();
        return deck;
    }
}
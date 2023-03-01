using System.Net.NetworkInformation;

namespace OOP_ICT;

public class CardDeck
{
    private List<Card> deck = new List<Card>();
    public CardDeck()
    {
        string[] suits = { "Spades", "Hearts", "Diamonds", "Clubs" };
        string[] faceValues = { "Ace", "King", "Queen", "Jack", "10", "9", "8", "7", "6", "5", "4", "3", "2" };

        foreach (string suit in suits)
        {
            for (int i = 0; i < faceValues.Length; i++)
            {
                Card card = new Card(suit, faceValues[i]);
                deck.Add(card);
            }
        }

    }
    public void Shuffle()
    {
        Random rand = new Random();
        for (int i = deck.Count - 1; i > 0; i--)
        {
            int j = rand.Next(i + 1);
            (deck[i], deck[j]) = (deck[j],  deck[i]);
        }
    }
    public Card Draw()
    {
        Card card = deck.First();
        deck.RemoveAt(0);
        return card;
    }
    public List<string> Deck() {
        List<string> cards = new List<string>();
        foreach (Card card in deck)
        {
            cards.Add(card.Display());
        }
        return cards;

    }

}
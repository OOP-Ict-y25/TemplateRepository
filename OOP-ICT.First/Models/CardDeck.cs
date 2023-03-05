namespace OOP_ICT.Models;

public class CardDeck
{
    public List<Card> Cards = new();


    public CardDeck()
    {
        Initialise();
    }

    public void Shuffle()
    {
        var numOfCards = Cards.Count;
        int buffer = numOfCards / 2;

        List<Card> Left = new List<Card>();
        List<Card> Right = new List<Card>();

        for (int i = 0; i < buffer; i++)
            Left.Add(Cards[i]);

        for (int i = buffer; i < numOfCards; i++)
            Right.Add(Cards[i]);

        for (int i = 0; i < numOfCards / 2; i++)
        {
            Cards[i * 2] = Left[i];
            Cards[i * 2 + 1] = Right[i];
        }
    }

    private void Initialise()
    {
        foreach (Suits suit in Enum.GetValues(typeof(Suits)))
        foreach (Faces face in Enum.GetValues(typeof(Faces)))
            Cards.Add(new Card(face, suit));
    }
}
namespace OOP_ICT.Models;

public static class CardDeck
{
    public static List<Card> Create()
    {
        List<Card> cards = new ();
        foreach (CardSuitEnum cardSuit in Enum.GetValues(typeof(CardSuitEnum)))
        {
            foreach (CardValueEnum cardValue in Enum.GetValues(typeof(CardValueEnum)))
            {
                cards.Add(new Card(cardSuit, cardValue));
            }
        }

        return cards;
    }
}
namespace OOP_ICT;

public class UserDeck
{
    private List<Card> cards = new List<Card>();
    public void AddCard(Card card)
    {
        cards.Add(card);
    }
    public void Shuffle()
    {
        Random rand = new Random();
        for (int i = cards.Count-1; i > 0; i--)
        {
            int j = rand.Next(i + 1);
            (cards[i], cards[j]) = (cards[j], cards[i]);
        }

    }
    public void Show()
    {
        foreach (Card card in cards)
        {
            Console.WriteLine(card.Display());
        }
    }
}
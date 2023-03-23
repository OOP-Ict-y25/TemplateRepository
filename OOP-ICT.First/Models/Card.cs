namespace OOP_ICT;

public enum CardSuitEnum : ushort
{
    Hearts,
    Clubs,
    Spades,
    Diamonds
}

public enum CardValueEnum : ushort
{
    Ace,
    King,
    Queen,
    Jack,
    Ten,
    Nine,
    Eight,
    Seven,
    Six,
    Five,
    Four,
    Three,
    Two
}

public class Card
{
    
    public Card(CardSuitEnum cardSuit, CardValueEnum cardValue)
    {
        CardSuit = cardSuit;
        CardValue = cardValue;
    }

    public CardSuitEnum CardSuit { get; set; }
    public CardValueEnum CardValue { get; set; }
}
using OOP_ICT.Tools;

namespace OOP_ICT.Models;

/// <summary>
///  Creating enum for card values from aces up to the number two to identify value of card.
/// </summary>
public enum CardValue
{
    Ace = 0, King, Queen, Jack, Ten, Nine, Eight, Seven, Six, Five, Four, Three, Two
}

/// <summary>
///  Creating enum for card suits from hearts up to the spades to identify suit of card.
/// </summary>
public enum CardSuit
{
    Hearts = 0, Diamonds, Clubs, Spades
}

/// <summary>
///  Creating class card with its own value, suit and id, unique for each card in deck.
/// Creating builder for class Card with class validation, overrode ToString and GetHash methods.
/// </summary>
public class Card
{
    //public Card()
    private readonly int _id;
    private readonly CardValue _value;
    private readonly CardSuit _suit;
    public Card(CardValue value, CardSuit suit, int id)
    {
        if (id < 1)
        {
            throw new FirstException($"Invalid id, id - {id}");
        }

        if (!Enum.IsDefined(value))
        {
            throw new FirstException($"Invalid value, value - {value}");
        }

        if (!Enum.IsDefined(suit))
        {
            throw new FirstException($"Invalid suit, suit - {suit}");
        }
        
        this._value = value;
        this._suit = suit;
        this._id = id;
    }
 
    public override string ToString()
    {
        return $"{_value} {_suit}";
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_id, _value, _suit);
    }

    public int GetCardId()
    {
        return _id;
    }
    public bool Equals(Card fCard, Card sCard)
    {
        return fCard._id == sCard._id;
    }
}
namespace OOP_ICT.Models;

/// <summary>
///  Creating class deck, which contains 52 cards of each suit in order from aces up to the number two.
/// Creating default builder for class Deck to put cards in deck in the right order.
/// </summary>
public class CardDeck
{
    private readonly List<Card> _cards = new List<Card>(52);
    internal bool DeckUnpacked = false;
    public CardDeck()
    {
        var i = 1;
        foreach (var value in (CardValue[])Enum.GetValues(typeof(CardValue)))
        {
            foreach (var suit in (CardSuit[])Enum.GetValues(typeof(CardSuit)))
            {
                var card = new Card(value, suit, i);
                _cards.Add(card);
                i++;
            }
        }
    }

    /// <summary>
    /// ShuffleDeck - shuffling deck in random order.
    /// </summary>
    /// <returns></returns>
    public CardDeck ShuffleDeck()
    {
        var random = new Random();
        var newShuffledDeck = new CardDeck();
        var deckCount = _cards.Count;
        for(var i = 0; i < deckCount; i++)
        {
            var randomElementInDeck = random.Next(0, _cards.Count);
            newShuffledDeck.Add(_cards[randomElementInDeck]);
            _cards.Remove(_cards[randomElementInDeck]);
        }

        DeckUnpacked = true;
        return newShuffledDeck;
    }
    /// <summary>
    /// Count - return amount of cards in deck.
    /// </summary>
    /// <returns></returns>
    internal int Count() => _cards.Count;

    /// <summary>
    /// Add - adding card to deck.
    /// </summary>
    /// <param name="card"></param>
    private void Add(Card card)
    {
        _cards.Add(card);
    }
    
/// <summary>
/// GetLastCard - return last card in deck.
/// </summary>
/// <returns></returns>
    public Card GetLastCard()
    {
        return _cards[^1];
    }

/// <summary>
/// GetFirstCard - return first card in deck.
/// </summary>
/// <returns></returns>
public Card GetFirstCard()
{
    return _cards[0];
}

/// <summary>
/// DeleteLastCard - delete last card in deck.
/// </summary>
    public void DeleteLastCard()
    {
        _cards.RemoveAt(_cards.Count-1);
    }

/// <summary>
/// GetDeck - return string contains all cards in deck.
/// </summary>
/// <param name="deck"></param>
/// <returns></returns>
    public static string GetDeck(CardDeck deck)
    {
        var deckNames = "";
        for (var i = 0; i < deck.Count(); i++)
        {
            deckNames += deck._cards[i].ToString();
            deckNames += "\r\n";
        }

        return deckNames;
    }
}
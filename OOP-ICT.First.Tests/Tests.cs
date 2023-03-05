using OOP_ICT.Models;
using Xunit;

namespace OOP_ICT.Dealer.Tests;

public class Tests
{
    [Fact]
    public void CollectionsAreEquals_True()
    {
        CardDeck cardDeck = new CardDeck();
        Models.Dealer dealer = new Models.Dealer(cardDeck);

        List<Card> original = dealer.ShowOriginal().Cards;
        List<Card> shuffled = dealer.GetShuffledUseDeck().Cards;

        Assert.Equal(original, shuffled);
    }
    
/*    [Fact]
    public void ValueContainsInCollection_True()
    {
        CardDeck cardDeck = new CardDeck();
        Models.Dealer dealer = new Models.Dealer(cardDeck);

        List<Card> original = dealer.ShowOriginal().Cards;
        List<Card> shuffled = dealer.GetShuffledUseDeck().Cards;

        Card card = new Card(Faces.Jack, Suits.Spades);

       // Assert.Contains(card, original);
        Assert.Contains(card, shuffled);
    }*/

    [Fact]
    public void CheckForNullException_AssertNullRef()
    {
        CardDeck cardDeck = new CardDeck();
        Models.Dealer dealer = new Models.Dealer(cardDeck);

        List<Card> original = dealer.ShowOriginal().Cards;
        List<Card> shuffled = dealer.GetShuffledUseDeck().Cards;

        Assert.Throws<InvalidOperationException>(() => original.First(x => x == null));
        //Assert.Throws<InvalidOperationException>(() => shuffled.First(x => x == null));
    }

}
using OOP_ICT.Models;
using Xunit;

namespace OOP_ICT.First.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Fact]
    public void IsAll52()
    {
        Assert.True(CardDeck.Create().Count() == 52);
    }
      
    [Fact]
    public void NewCardDeckNoUserDeck()
    {
        var cardDeck = CardDeck.Create();
        var userDeck = Dealer.PerfectShuffle(cardDeck);
        for(var i = 0; i < 6; i++)
            userDeck = Dealer.PerfectShuffle(userDeck);
        Assert.AreNotEqual(cardDeck, userDeck);
    }
    
    [Fact]
    public void NextCard()
    {
        var cardDeck = CardDeck.Create();
        var userDeck = Dealer.PerfectShuffle(cardDeck);
        for(var i = 1; i < 52; i++)
            Assert.AreNotEqual(userDeck[i-1].CardSuit, userDeck[i].CardSuit);
    }
}
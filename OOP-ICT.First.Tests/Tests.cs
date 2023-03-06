using Xunit;
using Xunit.Sdk;
using OOP_ICT.Models;
using OOP_ICT.Tools;
using OOP_ICT.Interfaces;

namespace OOP_ICT.Dealer.Tests;

public class Tests
{
    // TODO: Обратите внимание, что для коллекций и проверок есть разные виды Assert
    [Fact]
    public void CheckTestIsWorking_CorrectBuild()
    {
        Assert.True(true);
    }
    
    [Fact]
        public void CheckFirstCards()
        {
            var fCard = new Card(CardValue.Ace, CardSuit.Hearts, 1);
            var testedDeck = new CardDeck();
            var firstCard = testedDeck.GetFirstCard();
            Assert.Equal(fCard.GetCardId(), firstCard.GetCardId());
        }   
        
        [Fact]
        public void CheckLastCards()
        {
            var lCard = new Card(CardValue.Two, CardSuit.Spades, 52);
            var testedDeck = new CardDeck();
            var lastCard = testedDeck.GetLastCard();
            Assert.Equal(lCard.GetCardId(), lastCard.GetCardId());
        }  
        
        [Fact]
        public void CheckShuffledDeck()
        {
            var lCard = new Card(CardValue.Two, CardSuit.Spades, 52);
            var testedDeck = new CardDeck();
            testedDeck = testedDeck.ShuffleDeck();
            var lastCard = testedDeck.GetLastCard();
            Assert.NotEqual(lCard.GetCardId(), lastCard.GetCardId());
        }  
        
        [Fact]
        public void CheckDeleteWork()
        {
            var lCard = new Card(CardValue.Two, CardSuit.Spades, 52);
            var testedDeck = new CardDeck();
            testedDeck.DeleteLastCard();
            var lastCard = testedDeck.GetLastCard();
            Assert.NotEqual(lCard.GetCardId(), lastCard.GetCardId());
        }  
        
        [Fact]
        public void CheckHandsOnStart()
        {
            var _dealer = new Models.Dealer();
            _dealer.InitializeCardDeck();
            _dealer.ShuffleDeckAtDealer();
            _dealer.InitiateGameStart();
            Assert.NotEqual(_dealer.GetDealerHandTest(), _dealer.GetPlayererHandTest());
        }  

    [Fact]
    public void CollectionsAreEquals_True()
    {
        var firstCollection = new List<int>(){1,2,3};
        var secondCollection = new List<int>(){1,2,3};
        Assert.Equal(firstCollection, secondCollection);
    }
    
    [Fact]
    public void ValueContainsInCollection_True()
    {
        var value = 2;
        var collection = new List<int>(){1,2,3};
        Assert.Contains(value, collection);
    }

    [Fact]
    public void CheckForNullException_AssertNullRef()
    {
        var collection = new List<string>() { "я", "люблю", "ооп" };
        Assert.Throws<InvalidOperationException>(() => collection.First(x => x == null));
    }
}
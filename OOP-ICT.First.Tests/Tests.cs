
using Xunit;
using Xunit.Sdk;
using OOP_ICT;
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
    public void CollectionsAreEquals_True()
    {
        CardDeck firstCollection = new CardDeck();
        CardDeck secondCollection = new CardDeck();
        secondCollection.Shuffle();
        Assert.NotEqual(firstCollection, secondCollection);
    }

    [Fact]
    public void ValueContainsInCollection_True()
    {
        var suits = new List<string>() { "Spades", "Hearts", "Diamonds", "Clubs" };
        var faceValues = new List<string>() { "Ace", "King", "Queen", "Jack", "10", "9", "8", "7", "6", "5", "4", "3", "2" };
        CardDeck collection = new CardDeck();
        foreach (string suit in suits)
        {
            foreach (string faceValue in faceValues)
            {
                Assert.Contains(string.Format("{0} of {1}", faceValue, suit),collection.Deck());
            }
        }
    }

    [Fact]
    public void CheckForNullException_AssertNullRef()
    {
        var collection = new List<string>() { "я", "люблю", "ооп" };
        Assert.Throws<InvalidOperationException>(() => collection.First(x => x == null));
    }
}
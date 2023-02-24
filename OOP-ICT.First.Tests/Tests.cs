using Xunit;
using Xunit.Sdk;

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
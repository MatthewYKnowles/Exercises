using NUnit.Framework;

namespace Excercise.Tests;

public class YahtzeeTests
{
    [Test]
    public void TestOne()
    {
        var yahtzee = new Yahtzee();

        var result = yahtzee.Score("ones", new List<int>{2, 1, 4, 6, 1});
        
        Assert.That(result, Is.EqualTo(2));
    }
    [Test]
    public void TestTwo()
    {
        var yahtzee = new Yahtzee();

        var result = yahtzee.Score("twos", new List<int>{2, 2, 4, 5, 2});
        
        Assert.That(result, Is.EqualTo(6));
    }
}
using NUnit.Framework;

namespace Excercise.Tests;

public class RomanNumeralTests
{
    [Test]
    public void TestOne()
    {
        var romanNumerals = new RomanNumerals();
        
        var result = romanNumerals.Convert(1);
        
        Assert.That(result, Is.EqualTo("I"));
    }
    
    [Test]
    public void TestTwo()
    {
        var romanNumerals = new RomanNumerals();
        
        var result = romanNumerals.Convert(2);
        
        Assert.That(result, Is.EqualTo("II"));
    }
}
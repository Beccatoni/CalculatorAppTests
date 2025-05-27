using NUnit.Framework;
using NUnit.Framework.Legacy;
namespace CalculatorLib.Tests;

public class Tests
{
    private Calculator _calculator;
    
    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [Test]
    public void Add_ReturnsSum()
    {
        Assert.That(_calculator.Add(5, 5), Is.EqualTo(10));
        //Assert.AreEqual(10, _calculator.Add(5, 5));
        //ClassicAssert.AreEqual(10, _calculator.Add(5, 5));
    }
}
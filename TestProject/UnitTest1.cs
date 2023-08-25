using CalculatorLibrary;

namespace TestProject;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestAddMethod()
    {
        Calculator calc = new Calculator();
        Assert.AreEqual(30, calc.Add(10, 20));
    }
}
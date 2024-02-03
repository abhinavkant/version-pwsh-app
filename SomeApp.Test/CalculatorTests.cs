using DotnetFormatExample;

namespace SomeApp.Test;

public class CalculatorTest
{
    [Fact]
    public void AddTest()
    {
        var x = new Calculator();
        Assert.Equal(3, x.AddNumbers(1, 2));
    }

    [Fact]
    public void SubTest()
    {
        var x = new Calculator();
        Assert.Equal(-1, x.SubtractNumbers(1, 2));
    }

    [Fact]
    public void MultiplyNumbersTest()
    {
        var x = new Calculator();
        Assert.Equal(2, x.MultiplyNumbers(1, 2));
    }

    [Fact]
    public void DivideNumbersTest()
    {
        var x = new Calculator();
        Assert.Equal(0, x.DivideNumbers(1, 2));
    }

    [Fact]
    public void ModulasNumbersTest()
    {
        var x = new Calculator();
        Assert.Equal(0, x.ModulasNumbers(4, 2));
    }

    [Fact]
    public void LogNumbersTest()
    {
        var x = new Calculator();
        Assert.Equal(2, x.LogNumbers(4, 2));
    }
}

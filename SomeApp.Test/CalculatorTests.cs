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
}
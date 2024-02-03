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
}
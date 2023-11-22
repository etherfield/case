using Xunit;

namespace Net60TestProject;

public class MainTests
{
    [Theory]
    [JsonFileData("MISSING_all_data.json")]
    public void CanAddAll(int value1, int value2, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(value1, value2);

        Assert.Equal(expected, result);
    }

    [Theory]
    [JsonFileData("data.json", "AddData")]
    public void CanAdd(int value1, int value2, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(value1, value2);

        Assert.Equal(expected, result);
    }

    [Theory]
    [JsonFileData("data.json", "SubtractData")]
    public void CanSubtract(int value1, int value2, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Subtract(value1, value2);

        Assert.Equal(expected, result);
    }
}


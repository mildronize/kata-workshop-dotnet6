
namespace Kata.FizzBuzz.Tests;
public class FizzBuzzTests
{
    [Theory]
    [InlineData(1, "1")]
    public void CanTestSingleNumber(int input, string expected)
    {
        // Arrange
        var obj = new FizzBuzz();
        // Act
        var actual = obj.GetFizzBuzz(input);
        // Assert
        actual.Should().Be(expected);
    }
}


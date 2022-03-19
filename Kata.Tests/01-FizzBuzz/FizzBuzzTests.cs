
namespace Kata.FizzBuzz.Tests;
public class FizzBuzzTests
{
    [Theory]
    [InlineData(1, "1")]
    [InlineData(3, "Fizz")]
    [InlineData(6, "Fizz")]
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


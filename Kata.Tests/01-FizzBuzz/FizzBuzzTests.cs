
namespace Kata.FizzBuzz.Tests;
public class FizzBuzzTests
{
    [Theory]
    // 1 Case
    [InlineData(1, "1")]
    // Fizz Case
    [InlineData(3, "Fizz")]
    [InlineData(6, "Fizz")]

    // Buzz Case
    [InlineData(5, "Buzz")]

    // Otherwise Case
    [InlineData(2, "2")]

    // FizzBuzz Case
    [InlineData(15, "FizzBuzz")]
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


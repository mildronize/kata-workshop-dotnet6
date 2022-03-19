
namespace Kata.FizzBuzz.Tests;
public class FizzBuzzTests
{
    [Fact]
    public void CanTestSingleNumber()
    {
        // Arrange
        var obj = new FizzBuzz();
        // Act
        var actual = obj.GetFizzBuzz(1);
        // Assert
        actual.Should().Be("1");
    }
}


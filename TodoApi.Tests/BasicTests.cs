
using Xunit;

public class BasicTests
{
    [Fact]
    public void Addition_ShouldReturnCorrectResult()
    {
        // Arrange
        int a = 5;
        int b = 3;

        // Act
        int result = a + b;

        // Assert
        Assert.Equal(8, result);
    }
}

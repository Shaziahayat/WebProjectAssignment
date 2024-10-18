
namespace TestProject1
{
  
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            int expected = 2;
            int actual = 1 + 1;

            // Act and Assert
            Xunit.Assert.Equal(expected, actual);

        }
    }
}
namespace SimpleMathTests
{
    public class TestsBase
    {
        void TestAdd()
        {
            // Arrange
            MathOperations math = new MathOperations();

            // Act
            int result = math.Add(5, 7);

            // Assert
            Assert.AreEqual(12, result);
        }
    }
}
namespace SimpleMathTests
{
    [TestFixture]
    public class MathOperationsTests
    {
        [Test]
        public void Add_WhenGivenTwoIntegers_ReturnsCorrectSum()
        {
            // Arrange
            MathOperations math = new MathOperations();

            // Act
            int result = math.Add(3, 5);

            // Assert
            Assert.That(result, Is.EqualTo(8));
        }
    }
}
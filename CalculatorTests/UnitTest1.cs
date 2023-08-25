namespace CalculatorTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add_WhenGivenTwoIntegers_ReturnsSum()
        {
            Calculator calculator = new Calculator();

            int result = calculator.Add(3, 5);

            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void Subtract_WhenGivenTwoIntegers_ReturnsDifference()
        {
            Calculator calculator = new Calculator();

            int result = calculator.Subtract(10, 4);

            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void Multiply_WhenGivenTwoIntegers_ReturnsProduct()
        {
            Calculator calculator = new Calculator();

            int result = calculator.Multiply(6, 4);

            Assert.That(result, Is.EqualTo(24));
        }

        [Test]
        public void Divide_WhenDividingByNonZero_ReturnsQuotient()
        {
            Calculator calculator = new Calculator();

            double result = calculator.Divide(10, 2);

            Assert.That(result, Is.EqualTo(5.0).Within(0.001));
        }

        [Test]
        public void Divide_WhenDividingByZero_ThrowsArgumentException()
        {
            Calculator calculator = new Calculator();

            Assert.Throws<ArgumentException>(() => calculator.Divide(10, 0));
        }
    }
}
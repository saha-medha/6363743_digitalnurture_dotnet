using NUnit.Framework;
using CalcApp;

namespace CalcTestProject
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_ReturnsCorrectSum()
        {
            int result = _calculator.Add(2, 3);
            Assert.That(result, Is.EqualTo(5));
        }

        [TestCase(10, 5, 5)]
        [TestCase(0, 0, 0)]
        [TestCase(3, 10, -7)]
        public void Subtract_ReturnsCorrectDifference(int a, int b, int expected)
        {
            int result = _calculator.Subtract(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}

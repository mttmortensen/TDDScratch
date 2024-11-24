using TDDScratch;

namespace TDDScratch_Tests
{
    [TestClass]
    public class BasicCalculatorTests
    {
        [TestMethod]
        public void AdditionOfTwoNumbersTest()
        {
            // Arrange
            var calculator = new Calculator();
            int num1 = 2;
            int num2 = 3;

            //Act 
            int result = calculator.Add(num1, num2);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void MultiplyTwoNumbers()
        {
            var calculator = new Calculator();
            int num1 = 4;
            int num2 = 5;

            int result = calculator.Multiply(num1, num2);

            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void IsEvenTest()
        {
            // Arrange 
            var calculator = new Calculator();

            // Act
            bool isEven = calculator.IsEven(10);

            // Assert 
            Assert.IsTrue(isEven);
        }

        [TestMethod]
        public void FahrenheitToCelsiusTest()
        {
            var calculator = new Calculator();

            // Act
            double celsius = calculator.FahrenheitToCelsius(75);

            // Assert 
            Assert.AreEqual(23, celsius);
        }
    }

    [TestClass]
    public class DSATests
    {
        [TestMethod]
        public void ReverseStringTest()
        {
            var dsa = new DSA();

            string reversed = dsa.ReverseString("hello");

            Assert.AreEqual("olleh", reversed);
        }
    }
}

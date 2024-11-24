using TDDScratch;

namespace TDDScratch_Tests
{
    [TestClass]
    public sealed class BasicCalculatorTests
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
    }
}

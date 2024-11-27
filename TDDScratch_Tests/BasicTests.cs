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

        [TestMethod]
        public void GetAreaOfRectangleTest()
        {
            var calculator = new Calculator();

            int area = calculator.CalculateRectangleArea(5, 10);

            Assert.AreEqual(50, area);
        }
    }

    [TestClass]
    public class DSATests
    {
        [TestMethod]
        public void ReverseStringTest()
        {
            var dsa = new DSA();

            string reversed = dsa.ReverseString("acceleration");

            Assert.AreEqual("noitarelecca", reversed);
        }

        [TestMethod]
        public void IsPrimeTest()
        {
            var dsa = new DSA();

            bool isPrime = dsa.IsPrime(4);

            Assert.IsFalse(isPrime);
        }

        [TestMethod]
        public void CountWordsTest()
        {
            var dsa = new DSA();

            int wordCount = dsa.CountWords("hello world my name is Matt");

            Assert.AreEqual(6, wordCount);
        }
    }

    [TestClass]
    public class LoopsTests
    {
        [TestMethod]
        public void SumOfNumbersTest()
        {
            var loops = new Loops_112724();

            int sum = loops.SumOfNumbers(10);

            Assert.AreEqual(55, sum);
            // This would mean the answer would need to look like so: 
            // 1 + 2 + 3 + 4 + 5 = 15
        }
    }
}

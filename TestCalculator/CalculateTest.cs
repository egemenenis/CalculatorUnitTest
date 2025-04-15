namespace TestCalculator
{
    [TestClass]
    public sealed class CalculateTest
    {
        [TestMethod]
        public void Addition()
        {
            CalculatorUnitTest.ClsCalculator _calculator = new CalculatorUnitTest.ClsCalculator();
            int result = _calculator.addition(20, 10);

            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void Subtraction()
        {
            CalculatorUnitTest.ClsCalculator _calculator = new CalculatorUnitTest.ClsCalculator();
            int result = _calculator.subtraction(50, 10);

            Assert.AreEqual(40, result);
        }

        [TestMethod]
        public void Multiplication()
        {
            CalculatorUnitTest.ClsCalculator _calculator = new CalculatorUnitTest.ClsCalculator();
            int result = _calculator.multiplication(8, 3);

            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void Division()
        {
            CalculatorUnitTest.ClsCalculator _calculator = new CalculatorUnitTest.ClsCalculator();
            int result = _calculator.division(70, 35);

            Assert.AreEqual(2, result);
        }
    }
}
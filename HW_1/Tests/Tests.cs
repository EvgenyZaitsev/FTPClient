using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void SumTest()
        {
            Calc c = new Calc();
            double a = 10;
            double b = 45;
            double sum = c.Sum(a, b);
            Assert.AreEqual(a + b, sum);
        }
        [TestMethod]
        public void DivideTest()
        {
            Calc c = new Calc();
            double a = 10;
            double b = 45;
            double div = c.Divide(a, b);
            Assert.AreEqual(a / b, div);
        }
        [TestMethod]
        public void SubtractionTest()
        {
            Calc c = new Calc();
            double a = 10;
            double b = 45;
            double sub = c.Subtraction(a, b);
            Assert.AreEqual(a - b, sub);
        }
        [TestMethod]
        public void MultTest()
        {
            Calc c = new Calc();
            double a = 10;
            double b = 45;
            double mult = c.Multiply(a, b);
            Assert.AreEqual(a * b, mult);
        }
    }
}

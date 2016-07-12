using System;
using System.Linq;
using Xunit;
using Calculator;

namespace CalcTest_xUint
{
    public class Xunit
    {
        [Fact]
        /*[Category("Smoke")]
        [Timeout(10000)]
        [Description("Smoke")]*/
        public void SmokeFact()
        {
            Calc c = new Calc();
            Assert.NotEqual(null, c);
        }

        [Fact(Skip ="Because I can")]
        /*[Category("Daily")]
        [Timeout(10000)]
        [Description("Ignore")]*/
        public void IgnoreFact()
        {
            Calc c = new Calc();
            Random r = new Random();
            double a = r.NextDouble();
            double b = r.NextDouble();
            double d = a + b;
        }

        [Fact]
        /*[Category("Daily")]
        [Timeout(10000)]
        [Description("Sum")]*/
        public void SumFact()
        {
            Calc c = new Calc();
            Random r = new Random();
            double a = r.NextDouble();
            double b = r.NextDouble();
            Assert.True((a + b) == c.Sum(a, b));
        }
        [Fact]
        /*[Category("Daily")]
        [Timeout(10000)]
        [Description("Sub")]*/
        public void SubFact()
        {
            Calc c = new Calc();
            Random r = new Random();
            double a = r.NextDouble();
            double b = r.NextDouble();
            Assert.True((a - b) == c.Subtract(a, b));
        }
        [Fact]
        /*[Category("Daily")]
        [Timeout(10000)]
        [Description("Mult")]*/
        public void MultFact()
        {
            Calc c = new Calc();
            Random r = new Random();
            double a = r.NextDouble();
            double b = r.NextDouble();
            Assert.True((a * b) == c.Multiply(a, b));
        }
        [Fact]
        /*[Category("Daily")]
        [Timeout(10000)]
        [Description("Div")]
        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(2, 2)]
        [TestCase(4, 2)]*/
        public void DivFact()
        {
            Calc c = new Calc();
            Random r = new Random();
            double a = r.NextDouble();
            double b = r.NextDouble();
            Assert.True((a / b) == c.Divide(a, b));
        }

/*        [Fact]
        [Timeout(1000)]
        [Description("Timeout")]
        public void TimeoutFact()
        {
            int i = 0;
            while (true)
            {
                if (i % 2 == 0)
                    i++;
                else
                    i--;
            }
        }
*/
        [Fact]
        /*[Timeout(1000)]
        [Description("Exception")]*/
        public void ExceptionFact()
        {
            Calc c = new Calc();
            Assert.Throws<DivideByZeroException>(() => c.Divide(5, 0));
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace CalcTest_MSTest
{
    [TestClass]
    public class CalcTest : BaseClass
    {
/*        [ClassInitialize]
        static public void ClassInit(TestContext context)
        {
            Console.WriteLine($"ClassInit + {context.TestName}");
        }
        [ClassCleanup]
        static public void ClassCleanup()
        {
            Console.WriteLine($"ClassCleanup");
        }
        [TestInitialize]
        public void Init()
        {
            Console.WriteLine($"TestMethodInit");
        }
        [TestCleanup]
        public void Cleanup()
        {
            Console.WriteLine($"TestMethodleanup");
        }
*/

        [TestCategory("Smoke")]
        [TestMethod]
        [Timeout(10000)]
        [Owner("ZaitsevED")]
        [Description("Smoke")]
        public void SmokeTest()
        {
            Calc c = new Calc();
            Assert.IsNotNull(c);
        }

        [Ignore]
        [TestCategory("Daily")]
        [TestMethod]
        [Timeout(10000)]
        [Owner("ZaitsevED")]
        [Description("Ignore")]
        public void IgnoreTest()
        {
            Calc c = new Calc();
            Random r = new Random();
            double a = r.NextDouble();
            double b = r.NextDouble();
            double d = a + b;
        }

        [TestCategory("Daily")]
        [TestMethod]
        [Timeout(10000)]
        [Owner("ZaitsevED")]
        [Description("Sum")]
        public void SumTest()
        {
            Calc c = new Calc();
            Random r = new Random();
            double a = r.NextDouble();
            double b = r.NextDouble();
            Assert.AreEqual(a + b, c.Sum(a, b));
        }
        [TestCategory("Daily")]
        [TestMethod]
        [Timeout(10000)]
        [Owner("ZaitsevED")]
        [Description("Sub")]
        public void SubTest()
        {
            Calc c = new Calc();
            Random r = new Random();
            double a = r.NextDouble();
            double b = r.NextDouble();
            Assert.AreEqual(a - b, c.Subtract(a, b));
        }
        [TestCategory("Daily")]
        [TestMethod]
        [Timeout(10000)]
        [Owner("ZaitsevED")]
        [Description("Mult")]
        public void MultTest()
        {
            Calc c = new Calc();
            Random r = new Random();
            double a = r.NextDouble();
            double b = r.NextDouble();
            Assert.AreEqual(a * b, c.Multiply(a, b));
        }
        [TestCategory("Daily")]
        [TestMethod]
        [Timeout(10000)]
        [Owner("ZaitsevED")]
        [Description("Div")]
        public void DivTest()
        {
            Calc c = new Calc();
            Random r = new Random();
            double a = r.NextDouble();
            double b = r.NextDouble();
            Assert.AreEqual(a / b, c.Divide(a, b));
        }

        [TestCategory("Daily")]
        [TestMethod]
        [Timeout(1000)]
        [Owner("ZaitsevED")]
        [Description("Timeout")]
        public void TimeoutTest()
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

        [TestCategory("Daily")]
        [TestMethod]
        [Timeout(1000)]
        [Owner("ZaitsevED")]
        [Description("Exception")]
        [ExpectedException(typeof(DivideByZeroException))]
        public void ExceptionTest()
        {
            Calc c = new Calc();
            c.Divide(5, 0);
        }

    }
}

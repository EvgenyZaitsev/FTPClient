namespace CalcTest_NUnit
{
    using Calculator;
    using NUnit;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class NUnitTests //: BaseClass
    {
        /*        [TestFixtureSetUp]
                static public void TextFixtureInit(TestContext context)
                {
                    Console.WriteLine($"TextFixtureInit");
                }
                [TestFixtureTearDown]
                static public void TextFixtureCleanup()
                {
                    Console.WriteLine($"TextFixtureCleanup");
                }
                [SetUp]
                public void Init()
                {
                    Console.WriteLine($"TestInit");
                }
                [TearDown]
                public void Cleanup()
                {
                    Console.WriteLine($"Testleanup");
                }
        */
/*        [TestFixtureSetUp]
        static public void ClassInit(TestContext context)
        {
            Console.WriteLine($"ClassInit");
        }
        [TestFixtureTearDown]
        static public void ClassCleanup()
        {
            Console.WriteLine($"ClassCleanup");
        }
        [SetUp]
        public void Init()
        {
            Console.WriteLine($"TestMethodInit {TestContext.CurrentContext}");
        }
        [TearDown]
        public void Cleanup()
        {
            Console.WriteLine($"TestMethodleanup");
        }*/
        [Test]
        [Category("Smoke")]
        [Timeout(10000)]
        [Description("Smoke")]
        public void SmokeTest()
        {
            Calc c = new Calc();
            Assert.AreNotEqual(null, c);
        }

        [Test]
        [Ignore("Because I can")]
        [Category("Daily")]
        [Timeout(10000)]
        [Description("Ignore")]
        public void IgnoreTest()
        {
            Calc c = new Calc();
            Random r = new Random();
            double a = r.NextDouble();
            double b = r.NextDouble();
            double d = a + b;
        }

        [Test]
        [Category("Daily")]
        [Timeout(10000)]
        [Description("Sum")]
        public void SumTest()
        {
            Calc c = new Calc();
            Random r = new Random();
            double a = r.NextDouble();
            double b = r.NextDouble();
            Assert.IsTrue((a + b) == c.Sum(a, b));
        }
        [Test]
        [Category("Daily")]
        [Timeout(10000)]
        [Description("Sub")]
        public void SubTest()
        {
            Calc c = new Calc();
            Random r = new Random();
            double a = r.NextDouble();
            double b = r.NextDouble();
            Assert.IsTrue((a - b) == c.Subtract(a, b));
        }
        [Test]
        [Category("Daily")]
        [Timeout(10000)]
        [Description("Mult")]
        public void MultTest()
        {
            Calc c = new Calc();
            Random r = new Random();
            double a = r.NextDouble();
            double b = r.NextDouble();
            Assert.IsTrue((a * b) == c.Multiply(a, b));
        }
        [Test]
        [Category("Daily")]
        [Timeout(10000)]
        [Description("Div")]
        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(2, 2)]
        [TestCase(4, 2)]
        public void DivTest(double a, double b)
        {
            Calc c = new Calc();
            Random r = new Random();
            Assert.IsTrue((a / b) == c.Divide(a, b));
        }

        [Test]
        [Timeout(1000)]
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

        [Test]
        [Timeout(1000)]
        [Description("Exception")]
        public void ExceptionTest()
        {
            Calc c = new Calc();
            Assert.Throws<DivideByZeroException>(() => c.Divide(5, 0));
        }
    }
}

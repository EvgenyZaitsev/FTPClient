namespace NUnit
{
    using NUnit.Framework;
    using System;
    [TestFixture]
    public class BaseClass
    {
        [TestFixtureSetUp]
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
        }
    }
}

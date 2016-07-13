using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW_6_2;
namespace HW_6_2_Tests
{
    [TestClass]
    public class HW_6_2_Tests
    {
        [ClassInitialize]
        static public void ClassInit(TestContext context)
        {
            Console.WriteLine($"ClassInit {context.TestName}");
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

        [TestMethod]
        public void CheckIntegerNumberEasy()
        {
            ParseIntEasy pie = new ParseIntEasy("12345");
            int number;
            pie.TryParse(out number);
            Assert.AreEqual(12345, number);
        }

        [TestMethod]
        public void CheckIntegerNumberHard()
        {
            ParseIntHard pih = new ParseIntHard("12345");
            int number;
            pih.TryParse(out number);
            Assert.AreEqual(12345, number);
        }

        [TestMethod]
        public void CheckDoubleNumberEasy()
        {
            ParseIntEasy pie = new ParseIntEasy("1234.5");
            int number;
            int result = pie.TryParse(out number);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void CheckDoubleNumberHard()
        {
            ParseIntHard pih = new ParseIntHard("1234.5");
            int number;
            int result = pih.TryParse(out number);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CheckOutOfIntegerNumberEasy()
        {
            ParseIntEasy pie = new ParseIntEasy("999999999999");
            int number;
            int result = pie.TryParse(out number);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void CheckOutOfIntegerNumberHard()
        {
            ParseIntHard pih = new ParseIntHard("999999999999");
            int number;
            int result = pih.TryParse(out number);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void CheckStringNumberEasy()
        {
            ParseIntEasy pie = new ParseIntEasy("123Hello");
            int number;
            int result = pie.TryParse(out number);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CheckStringNumberHard()
        {
            ParseIntHard pih = new ParseIntHard("123Hello");
            int number;
            int result = pih.TryParse(out number);
            Assert.AreEqual(0, result);
        }
    }
}

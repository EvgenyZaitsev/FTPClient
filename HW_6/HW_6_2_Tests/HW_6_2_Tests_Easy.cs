using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW_6_2;
namespace HW_6_2_Tests
{
    [TestClass]
    public class HW_6_2_Tests_Easy : HW_6_2_Tests_Base
    {
        [TestMethod]
        public void CheckIntegerNumberEasy()
        {
            ParseIntEasy pie = new ParseIntEasy("12345");
            int number;
            pie.TryParse(out number);
            Assert.AreEqual(12345, number);
        }

        [TestMethod]
        public void CheckZeroIntegerNumberEasy()
        {
            ParseIntEasy pie = new ParseIntEasy("0");
            int number;
            pie.TryParse(out number);
            Assert.AreEqual(0, number);
        }

        [TestMethod]
        public void CheckNegativeZeroIntegerNumberEasy()
        {
            ParseIntEasy pie = new ParseIntEasy("-0");
            int number;
            pie.TryParse(out number);
            Assert.AreEqual(-0, number);
        }

        [TestMethod]
        public void CheckNegativeIntegerNumberEasy()
        {
            ParseIntEasy pie = new ParseIntEasy("-12345");
            int number;
            pie.TryParse(out number);
            Assert.AreEqual(-12345, number);
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
        public void CheckNegativeDoubleNumberEasy()
        {
            ParseIntEasy pie = new ParseIntEasy("-1234.5");
            int number;
            int result = pie.TryParse(out number);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void CheckOutOfIntegerNumberEasy()
        {
            ParseIntEasy pie = new ParseIntEasy("21474836478");
            int number;
            int result = pie.TryParse(out number);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void CheckAlmostOutOfIntegerNumberEasy()
        {
            ParseIntEasy pie = new ParseIntEasy("2147483647");
            int number;
            pie.TryParse(out number);
            Assert.AreEqual(Int32.MaxValue, number);
        }

        [TestMethod]
        public void CheckNegativeOutOfIntegerNumberEasy()
        {
            ParseIntEasy pie = new ParseIntEasy("-2147483649");
            int number;
            int result = pie.TryParse(out number);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void CheckNegativeAlmostOutOfIntegerNumberEasy()
        {
            ParseIntEasy pie = new ParseIntEasy("-2147483648");
            int number;
            pie.TryParse(out number);
            Assert.AreEqual(Int32.MinValue, number);
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
        public void CheckEmptyStringEasy()
        {
            ParseIntEasy pie = new ParseIntEasy("");
            int number;
            int result = pie.TryParse(out number);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CheckNullStringEasy()
        {
            ParseIntEasy pie = new ParseIntEasy(null);
            int number;
            int result = pie.TryParse(out number);
            Assert.AreEqual(0, result);
        }
    }
}

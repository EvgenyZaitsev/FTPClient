using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW_6_2;

namespace HW_6_2_Tests
{
    [TestClass]
    public class HW_6_2_Tests_Hard : HW_6_2_Tests_Base
    {
        [TestMethod]
        public void CheckIntegerNumberHard()
        {
            ParseIntHard pih = new ParseIntHard("12345");
            int number;
            pih.TryParse(out number);
            Assert.AreEqual(12345, number);
        }

        [TestMethod]
        public void CheckZeroIntegerNumberHard()
        {
            ParseIntHard pih = new ParseIntHard("0");
            int number;
            pih.TryParse(out number);
            Assert.AreEqual(0, number);
        }

        [TestMethod]
        public void CheckNegativeZeroIntegerNumberHard()
        {
            ParseIntHard pih = new ParseIntHard("-0");
            int number;
            pih.TryParse(out number);
            Assert.AreEqual(-0, number);
        }

        [TestMethod]
        public void CheckNegativeIntegerNumberHard()
        {
            ParseIntHard pih = new ParseIntHard("-12345");
            int number;
            pih.TryParse(out number);
            Assert.AreEqual(-12345, number);
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
        public void CheckNegativeDoubleNumberHard()
        {
            ParseIntHard pih = new ParseIntHard("-1234.5");
            int number;
            int result = pih.TryParse(out number);
            Assert.AreEqual(0, result);
        }
        
        [TestMethod]
        public void CheckOutOfIntegerNumberHard()
        {
            ParseIntHard pih = new ParseIntHard("2147483648");
            int number;
            int result = pih.TryParse(out number);
            Assert.AreEqual(-1, result);
        }
        
        [TestMethod]
        public void CheckAlmostOutOfIntegerNumberHard()
        {
            ParseIntHard pih = new ParseIntHard("2147483647");
            int number;
            pih.TryParse(out number);
            Assert.AreEqual(Int32.MaxValue, number);
        }
        
        [TestMethod]
        public void CheckNegativeOutOfIntegerNumberHard()
        {
            ParseIntHard pih = new ParseIntHard("-2147483649");
            int number;
            int result = pih.TryParse(out number);
            Assert.AreEqual(-1, result);
        }
        
        [TestMethod]
        public void CheckNegativeAlmostOutOfIntegerNumberHard()
        {
            ParseIntHard pih = new ParseIntHard("-2147483648");
            int number;
            pih.TryParse(out number);
            Assert.AreEqual(Int32.MinValue, number);
        }
        
        [TestMethod]
        public void CheckStringNumberHard()
        {
            ParseIntHard pih = new ParseIntHard("123Hello");
            int number;
            int result = pih.TryParse(out number);
            Assert.AreEqual(0, result);
        }
        
        [TestMethod]
        public void CheckEmptyStringHard()
        {
            ParseIntEasy pie = new ParseIntEasy("");
            int number;
            int result = pie.TryParse(out number);
            Assert.AreEqual(0, result);
        }
        
        [TestMethod]
        public void CheckNullStringHard()
        {
            ParseIntEasy pie = new ParseIntEasy(null);
            int number;
            int result = pie.TryParse(out number);
            Assert.AreEqual(0, result);
        }
    }
}

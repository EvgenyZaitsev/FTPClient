using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HW_6_2_Tests
{
    [TestClass]
    public class HW_6_2_Tests_Base
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
    }

}

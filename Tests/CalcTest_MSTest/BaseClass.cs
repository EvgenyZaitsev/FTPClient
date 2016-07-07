using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTest_MSTest
{
    [TestClass]
    public class BaseClass
    {
        [ClassInitialize]
        static public void ClassInit(TestContext context)
        {
            Debug.WriteLine($"ClassInit");
        }
        [ClassCleanup]
        static public void ClassCleanup()
        {
            Debug.WriteLine($"ClassCleanup");
        }
        [TestInitialize]
        public void Init()
        {
            Debug.WriteLine($"TestMethodInit");
        }
        [TestCleanup]
        public void Cleanup()
        {
            Debug.WriteLine($"TestMethodleanup");
        }
    }
}

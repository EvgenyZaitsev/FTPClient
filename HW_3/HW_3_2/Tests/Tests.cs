using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW_3_2.Page;
namespace HW_3_2.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void checkSave()
        {
            Business b = new Business();
            b.setData();
            Assert.AreNotEqual(null, b);
        }
    }
}

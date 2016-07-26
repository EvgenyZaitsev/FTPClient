using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Logic.Steps;
using FrameworkCore.Core.Utility.WebDriver;
namespace Framework.Logic.Tests
{
    [TestClass]
    public class GMailTests
    {
        [TestMethod]
        public void CheckingForSpam()
        {
            Spam a = new Spam();
            Assert.IsTrue(a.AutorizeAndCheckSpam());
            WebDriver.CloseDriver();
        }
        [TestMethod]
        public void CheckingForForward()
        {
            Forward f = new Forward();
            Assert.IsTrue(f.ForwardMailToAnotherUser());
            WebDriver.CloseDriver();
        }
    }
}

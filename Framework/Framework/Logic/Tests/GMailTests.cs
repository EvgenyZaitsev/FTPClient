using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Logic.Steps;
using FrameworkCore.Core.Utility.WebDriver;
using Framework.Logic.Pages;

namespace Framework.Logic.Tests
{
    [TestClass]
    public class GMailTests
    {
        //[TestInitialize]
        //public void TestInitialize()
        //{
        //    WebDriver.ReCreateDriver();
        //}

        [TestCleanup]
        public void TestCleanUp()
        {
            //    WebDriver.CloseDriver();
            EmailPage ep = new EmailPage();
            LoginPage lp = new LoginPage();
            try
            {
                ep.Logout();
                lp.SwitchUser();
            }
            catch (Exception) { }
        }
        [TestMethod]
        public void CheckingForSpam()
        {
            Spam a = new Spam();
//            try
//            {
                Assert.IsTrue(a.AutorizeAndCheckSpam());
//            }
//            finally {
//                WebDriver.CloseDriver();
//            }
        }
        [TestMethod]
        public void CheckingForForward()
        {
            Forward f = new Forward();
            Assert.IsTrue(f.ForwardMailToAnotherUser());
            //WebDriver.CloseDriver();
        }
        [TestMethod]
        public void CheckingForBigAttachment()
        {
            Attachment a = new Attachment();
            Assert.IsTrue(a.BigAttachment());
            //WebDriver.CloseDriver();
        }
    }
}

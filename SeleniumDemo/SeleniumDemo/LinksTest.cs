using OpenQA.Selenium;
using SeleniumDemo.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemo
{
    [TestClass]
    public class LinksTest:BaseTest
    {
        [TestMethod]
        public void VerifyLinks()
        {

            var page1 = new PageClass1(driver);
            var page2 = new PageClass2(driver);
            page1.ClickOnPageLink();
            var linkDisplay = page2.ValidateLinks();
            Assert.IsTrue(linkDisplay,"Link Value should display under Link text");
           
           
        }
    }
}

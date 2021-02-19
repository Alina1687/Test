using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.PageObjects
{
    partial class BlogPage
    {
        public void VerifyElementIsDisplayed(IWebElement elementToVerify)
        {
            Assert.IsTrue(elementToVerify.Displayed);

        }
    }
}

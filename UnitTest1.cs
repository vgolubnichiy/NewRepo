using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace adressbook_web_tests
{
    [TestFixture]
    public class UntitledTestCase
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "https://localhost/addressbook";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheUntitledTestCaseTest()
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.CssSelector("form[id='LoginForm'] input[name='user']")).Click();
            driver.FindElement(By.CssSelector("form[id='LoginForm'] input[name='user']")).Clear();
            driver.FindElement(By.CssSelector("form[id='LoginForm'] input[name='user']")).SendKeys("admin");
            driver.FindElement(By.CssSelector("form[name='LoginForm'] input[name='pass']")).Click();
            driver.FindElement(By.CssSelector("form[id='LoginForm'] input[name='pass']")).Clear();
            driver.FindElement(By.CssSelector("form[id='LoginForm'] input[name='pass']")).SendKeys("secret");
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
            driver.FindElement(By.CssSelector("div[id='nav'] li[class='admin']")).Click();
            driver.FindElement(By.CssSelector("div[id='content'] input[name='new']")).Click();            
            driver.FindElement(By.CssSelector("input[name='group_name']")).Click();
            driver.FindElement(By.CssSelector("input[name='group_name']")).Clear();
            driver.FindElement(By.CssSelector("input[name='group_name']")).SendKeys("r");
            driver.FindElement(By.CssSelector("textarea[name='group_header']")).Click();
            driver.FindElement(By.CssSelector("textarea[name='group_header']")).Clear();
            driver.FindElement(By.CssSelector("textarea[name='group_header']")).SendKeys("r");
            driver.FindElement(By.CssSelector("textarea[name='group_footer']")).Click();
            driver.FindElement(By.CssSelector("textarea[name='group_footer']")).Clear();
            driver.FindElement(By.CssSelector("textarea[name='group_footer']")).SendKeys("r");
            driver.FindElement(By.CssSelector("input[name='submit']")).Click();
            driver.FindElement(By.CssSelector("a[href='group.php']")).Click();
            driver.FindElement(By.CssSelector("div[id='top'] a[href='#']")).Click();
        }
       
    }
}
